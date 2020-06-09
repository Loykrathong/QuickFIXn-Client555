using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuickFix;
using QuickFix.Fields;
using QuickFix.FIX42;

namespace GUI
{
    public partial class board : Form
    {
        string a ;
        char checktype;
        bool checkcustomer = false;
        private Dictionary<string, Market> dictionary = new Dictionary<string, Market>();
        readonly Init f = new Init();
        public void SendMessage(QuickFix.Message m)
        {
            if (f._session != null)
            {
                MessageBox.Show("Send complete!");
                f._session.Send(m);
            }
            else
            {
                MessageBox.Show("Fail to send order!");
            }            
        }
        public board()
        {         
            InitializeComponent();
            
        }

        private void board_Load(object sender, EventArgs e)
        {
       
        }
       
        private void QueryEnterOrder()
        {
            QuickFix.FIX42.NewOrderSingle m = QueryNewOrderSingle42();

            if (m != null)
            {
                m.Header.GetString(Tags.BeginString);
                SendMessage(m);
                listViewBid.Items.Clear();
                listViewAsk.Items.Clear();
                listViewBid.Invoke(new Action(() =>
                {
                    if (a == "buy")
                    {
                        if (!dictionary.ContainsKey(SymbolTextbox.Text))
                        {
                            //add
                            dictionary.Add(SymbolTextbox.Text, new Market(Convert.ToDouble(PendingPrice.Text), Convert.ToDouble(QtyPending.Text), Side.BUY.ToString()));
                        }
                        else
                        {
                            dictionary[SymbolTextbox.Text].bid.Add(new KeyValuePair<double, Order>(Convert.ToDouble(PendingPrice.Text), new Order(Convert.ToDouble(PendingPrice.Text), Convert.ToDouble(QtyPending.Text), Side.BUY.ToString())));
                        }                                        
                    }
                    else if (a == "sell")
                    {
                        if (!dictionary.ContainsKey(SymbolTextbox.Text))
                        {
                            //add
                            dictionary.Add(SymbolTextbox.Text, new Market(Convert.ToDouble(PendingPrice.Text), Convert.ToDouble(QtyPending.Text), Side.SELL.ToString()));
                        }
                        else
                        {
                            dictionary[SymbolTextbox.Text].ask.Add(new KeyValuePair<double, Order>(Convert.ToDouble(PendingPrice.Text), new Order(Convert.ToDouble(PendingPrice.Text), Convert.ToDouble(QtyPending.Text), Side.SELL.ToString())));
                        }
                    }
                    for (int i = 0; i < dictionary[SymbolTextbox.Text].bid.Count; i++)
                    {
                        ListViewItem Bidrow = new ListViewItem(new string[] { dictionary[SymbolTextbox.Text].bid[i].Value.Quantity.ToString(), dictionary[SymbolTextbox.Text].bid[i].Key.ToString() });
                        listViewBid.Items.Add(Bidrow);
                    }
                    for (int i = 0; i < dictionary[SymbolTextbox.Text].ask.Count; i++)
                    {
                        ListViewItem Askrow = new ListViewItem(new string[] { dictionary[SymbolTextbox.Text].ask[i].Key.ToString(), dictionary[SymbolTextbox.Text].ask[i].Value.Quantity.ToString() });
                        listViewAsk.Items.Add(Askrow);
                    }
                }
                ));
                SymbolListBox1.Items.Clear();
                foreach (string key in dictionary.Keys)
                {
                    SymbolListBox1.Items.Add(key);
                }
                labelSymbol.Text = SymbolTextbox.Text;
                SymbolTextbox.Text = "";
                PendingPrice.Text = "";               
                QtyPending.Text = "";
                IDPending.Text = "";
                QtyMarket.Text = "";
                checkCustomer1.Checked = false;
                checkCustomer2.Checked = false;               
            }
        }

        private void QueryMarketDataRequest()
        {
            QuickFix.FIX42.MarketDataRequest m = QueryMarketDataRequest42();
            if (m != null)
            {
                SendMessage(m);
                MessageBox.Show(m.ToString());
            }
                
        }

        private void QueryMarketDataIncremental()
        {
            QuickFix.FIX42.MarketDataIncrementalRefresh m = QueryMarketDataIncrementalRefresh42();
            if (m != null)
            {
                SendMessage(m);
                MessageBox.Show(m.ToString());
            }
        }

        private void QueryMarketDataSnapshotFullRefresh()
        {
            QuickFix.FIX42.MarketDataSnapshotFullRefresh m = QueryMarketDataSnapshotFullRefresh42();
            if (m != null)
            {
                SendMessage(m);
                MessageBox.Show(m.ToString());
            }

        }



        private QuickFix.FIX42.NewOrderSingle QueryNewOrderSingle42()
        {
            QuickFix.Fields.OrdType ordType = null;

            QuickFix.FIX42.NewOrderSingle newOrderSingle = new QuickFix.FIX42.NewOrderSingle(
                QueryClOrdID(),
                new HandlInst('1'),
                QuerySymbol(),
                QuerySide(),
                new TransactTime(DateTime.Now),
                ordType = QueryOrdType());

            
            newOrderSingle.Set(QueryOrderQty());
            newOrderSingle.Set(QueryTimeInForce());
            if (ordType.getValue() == OrdType.LIMIT || ordType.getValue() == OrdType.STOP_LIMIT)
                newOrderSingle.Set(QueryPrice());
            return newOrderSingle;
        }

        private QuickFix.FIX42.MarketDataRequest QueryMarketDataRequest42()
        {        
            MDReqID mdReqID = new MDReqID("MARKETDATAID");
            SubscriptionRequestType subType = new SubscriptionRequestType(SubscriptionRequestType.SNAPSHOT);
            MarketDepth marketDepth = new MarketDepth(0);

            QuickFix.FIX42.MarketDataRequest.NoMDEntryTypesGroup marketDataEntryGroup = new QuickFix.FIX42.MarketDataRequest.NoMDEntryTypesGroup();
            marketDataEntryGroup.Set(new MDEntryType(MDEntryType.BID));
            marketDataEntryGroup.Set(new MDEntryType(MDEntryType.OFFER));
            marketDataEntryGroup.Set(new MDEntryType(MDEntryType.TRADE));

            QuickFix.FIX42.MarketDataRequest.NoRelatedSymGroup symbolGroup = new QuickFix.FIX42.MarketDataRequest.NoRelatedSymGroup();
            symbolGroup.Set(new Symbol(RequestrichTextBox.Text.ToString()));
            

            QuickFix.FIX42.MarketDataRequest message = new QuickFix.FIX42.MarketDataRequest(mdReqID, subType, marketDepth);
            message.AddGroup(marketDataEntryGroup);
            message.AddGroup(symbolGroup);
            MessageBox.Show(message.ToString());
            return message;
        }

        private QuickFix.FIX42.MarketDataSnapshotFullRefresh QueryMarketDataSnapshotFullRefresh42()
        {
            Symbol symbol = new Symbol(RequestrichTextBox.Text);
            NoMDEntries noMDEntries = new NoMDEntries(0);
            QuickFix.FIX42.MarketDataSnapshotFullRefresh message = new QuickFix.FIX42.MarketDataSnapshotFullRefresh();
            message.Set(symbol);
            message.Set(noMDEntries);
            MessageBox.Show(message.ToString());
            return message;
        }

        private QuickFix.FIX42.MarketDataIncrementalRefresh QueryMarketDataIncrementalRefresh42()
        {
            MDReqID mdReqID = new MDReqID("MARKETDATAID");
            NoMDEntries noMDEntries = new NoMDEntries(0);
            QuickFix.FIX42.MarketDataIncrementalRefresh message = new QuickFix.FIX42.MarketDataIncrementalRefresh();
            message.Set(mdReqID);
            message.Set(noMDEntries);
            MessageBox.Show(message.ToString());
            return message;
        }



        private OrderQty QueryOrderQty()
        {
            if(checktype == 'm' )
                return new OrderQty(Convert.ToDecimal(QtyMarket.Text));
            else
                return new OrderQty(Convert.ToDecimal(QtyPending.Text));
        }   

        private ClOrdID QueryClOrdID()
        {
            if(checktype == 'm')
            {
                if(checkcustomer)
                {
                    return new ClOrdID("I1111");
                }
                else
                {
                    return new ClOrdID(System.Guid.NewGuid().ToString());
                }
            }
                
            else
                return new ClOrdID(IDPending.Text.Trim());
        }

        private QuickFix.Fields.Symbol QuerySymbol()
        {
            return new QuickFix.Fields.Symbol(SymbolTextbox.Text.Trim());
        }

        private Side QuerySide()
        {
            char c = ' ';
            if(a == "buy")
            {
                c = Side.BUY;
            }
            else if(a == "sell")
            {
                c = Side.SELL;
            }          
            return new Side(c);
        }

        private OrdType QueryOrdType()
        {
            char c = ' ';
            if (checktype == 'm')
            {
                c = OrdType.MARKET;
            }
            else if (checktype == 'l')
            {
                c = OrdType.LIMIT;
            }
            return new OrdType(c);
        }

        private TimeInForce QueryTimeInForce()
        {
            char c = ' ';
            c = TimeInForce.DAY;
            return new TimeInForce(c);
        }

        private Price QueryPrice()
        {
            return new Price(Convert.ToDecimal(PendingPrice.Text));
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void BuyMarket_Click(object sender, EventArgs e)
        {
            checktype = 'm';
            a = "buy";
            QueryEnterOrder();
        }

        private void SellMarket_Click(object sender, EventArgs e)
        {
            checktype = 'm';
            a = "sell";
            if(SymbolTextbox.Text!="")
            {
                QueryEnterOrder();
            }
            else

            {

            }
            
        }

        private void QtyMarket_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BidButton_Click(object sender, EventArgs e)
        {
            checktype = 'l';
            a = "buy";
            if(SymbolTextbox.Text != "" && PendingPrice.Text!="" && QtyPending.Text!= "" && IDPending.Text!="")
            {
                QueryEnterOrder();
            }
            else
            {
                MessageBox.Show("Please input symbol");
            }
            
        }

        private void AskButton_Click(object sender, EventArgs e)
        {
            checktype = 'l';
            a = "sell";
            if (SymbolTextbox.Text != "" && PendingPrice.Text != "" && QtyPending.Text != "" && IDPending.Text != "")
            {
                QueryEnterOrder();
            }
            else
            {
                MessageBox.Show("Please input symbol");
            }
        }

        private void checkCustomer1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkCustomer1.Checked == true)
            {
                IDPending.Text = "I1111";
                IDPending.BackColor = Color.Gray;
                IDPending.Cursor = Cursors.No;
                IDPending.ReadOnly = true;
            }
            else
            {
                IDPending.Text = null;
                IDPending.BackColor = Color.White;
                IDPending.Cursor = Cursors.IBeam;
                IDPending.ReadOnly = false;
            }
        }

        private void checkCustomer2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCustomer2.Checked == true)
            {
                checkcustomer = true;
            }
            else
            {
                checkcustomer = false;
            }
        }
        private void listViewOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PendingPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void listViewBid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewBid_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(SymbolListBox1.SelectedItem != null)
            {
                labelSymbol.Text = SymbolListBox1.SelectedItem.ToString();
                MessageBox.Show(SymbolListBox1.SelectedItem.ToString());
                listViewBid.Items.Clear();
                listViewAsk.Items.Clear();
                for (int i = 0; i < dictionary[SymbolListBox1.SelectedItem.ToString()].bid.Count; i++)
                {
                    ListViewItem Bidrow = new ListViewItem(new string[] { dictionary[SymbolListBox1.SelectedItem.ToString()].bid[i].Value.Quantity.ToString(), dictionary[SymbolListBox1.SelectedItem.ToString()].bid[i].Key.ToString() });
                    listViewBid.Items.Add(Bidrow);
                }
                for (int i = 0; i < dictionary[SymbolListBox1.SelectedItem.ToString()].ask.Count; i++)
                {
                    ListViewItem Askrow = new ListViewItem(new string[] { dictionary[SymbolListBox1.SelectedItem.ToString()].ask[i].Key.ToString(), dictionary[SymbolListBox1.SelectedItem.ToString()].ask[i].Value.Quantity.ToString() });
                    listViewAsk.Items.Add(Askrow);
                }               
            }      
        }


        private void RequestTest_Click(object sender, EventArgs e)
        {
            //QueryMarketDataRequest();
            //QueryMarketDataSnapshotFullRefresh();
            //QueryMarketDataIncremental();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
