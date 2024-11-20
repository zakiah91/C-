using System.Diagnostics;
using Timer = System.Windows.Forms.Timer;

namespace CashierGame
{
    //This app is created by: Zakiah Zulkefli
    public partial class Cashier : Form
    {

        private int selectedCheckListBoxIdx = 0;
        private int timerInSec = 0;
        private int dotIndex;
        private int currListViewPos;


        private String priceValueText = "";
        private String totalPriceString;

        private double totalPrice = 0.00;
        private double[] itemPrice = { 3.50, 8.00, 5.00, 2.15, 4.00 };

        private Boolean DEBUG = false;

        //zakiah06112024:dictionary<Number,Position>
        Dictionary<int, int> keyPad = new Dictionary<int, int>();

        public Cashier()
        {
            InitializeComponent();
            checkedListBox1.SelectedIndex = selectedCheckListBoxIdx;
            initKeyPadDictionary();
        }

        private void initKeyPadDictionary()
        {
            keyPad.Add(0, 9);
            keyPad.Add(1, 6);
            keyPad.Add(2, 7);
            keyPad.Add(3, 8);
            keyPad.Add(4, 3);
            keyPad.Add(5, 4);
            keyPad.Add(6, 5);
            keyPad.Add(7, 0);
            keyPad.Add(8, 1);
            keyPad.Add(9, 2);
            keyPad.Add(NumConstant.DOT_POS_IN_LIST_VIEW, 10);
            keyPad.Add(NumConstant.ENTER_POS_IN_LIST_VIEW, 11);
        }


        private int getKey(KeyEventArgs e)
        {
            return e.KeyValue;
        }

        private void log(String s)
        {
            if (DEBUG) Debug.WriteLine(s);
        }

        private void setSelectedNumpadListView(int listViewPosition)
        {
            numpad.Items[keyPad[listViewPosition]].Selected = true;
            numpad.Select();
        }

        private void gameOver()
        {
            resultLabel.Text = StringConstant.GAME_OVER;
            resultLabel.ForeColor = Color.Red;
            timerInSec = NumConstant.MAX_RUNNING_TIME + 1;
        }

        private void Cashier_KeyDown(object sender, KeyEventArgs e)
        {
            numpad.SelectedItems.Clear();
            log("key = " + getKey(e));

            try
            {
                if (getKey(e) == NumConstant.KEY_ENTER)
                {
                    setSelectedNumpadListView(NumConstant.ENTER_POS_IN_LIST_VIEW);
                    try
                    {
                        if (Double.Parse(priceValueText) == itemPrice[selectedCheckListBoxIdx])
                        {

                            checkedListBox1.SetItemChecked(selectedCheckListBoxIdx, true);
                            resultLabel.Text = (selectedCheckListBoxIdx + 1 == itemPrice.Length) ?
                                                    StringConstant.FINISH :
                                                    StringConstant.GOOD;
                        }
                        else
                        {
                            gameOver();
                            return;
                        }
                    }
                    catch
                    {
                        gameOver();
                        return;
                    }

                    selectedCheckListBoxIdx++;
                    checkedListBox1.SelectedIndex = (selectedCheckListBoxIdx < checkedListBox1.Items.Count) ?
                                                            selectedCheckListBoxIdx :
                                                            checkedListBox1.Items.Count - 1;

                    totalPrice += Math.Round(Double.Parse(priceValueText), 2);

                    totalPriceString = Math.Round(totalPrice, 2).ToString();

                    dotIndex = totalPriceString.IndexOf('.') + 1;

                    totalValue.Text = ((totalPriceString.Length - dotIndex) == 2) ?
                                                StringConstant.CURRENCY + " " + totalPriceString :
                                                StringConstant.CURRENCY + " " + totalPriceString + "0";


                    priceValue.Text = StringConstant.DEFAULT_PRICE;

                    priceValueText = "";

                    log(totalPriceString + "  " + totalPriceString.Length + " " + dotIndex);
                    log("<<<Press Enter >>>" + (totalPriceString.Length - dotIndex));

                }
                else if (getKey(e) == NumConstant.KEY_DOT)
                {
                    setSelectedNumpadListView(NumConstant.DOT_POS_IN_LIST_VIEW);
                    priceValueText += StringConstant.STR_DOT;
                }
                else
                {
                    log("key = " + getKey(e));
                    if (getKey(e) >= NumConstant.KEYPAD_0 && getKey(e) <= NumConstant.KEYPAD_9)
                        currListViewPos = getKey(e) - NumConstant.KEYPAD_0;
                    else if (getKey(e) >= NumConstant.KEY_0 && getKey(e) <= NumConstant.KEY_9)
                        currListViewPos = getKey(e) - NumConstant.KEY_0;
                    else
                        return;

                    setSelectedNumpadListView(currListViewPos);
                    priceValueText += (currListViewPos).ToString();
                    log("currListViewPos = " + currListViewPos);

                }

            }
            catch
            {
                //Error
            }

            if (getKey(e) != NumConstant.KEY_ENTER)
                priceValue.Text = StringConstant.CURRENCY + " " + priceValueText;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timerInSec += 1;
            if (resultLabel.Text == StringConstant.GAME_OVER)
            {
                return;
            }
            else if (timerInSec > NumConstant.MAX_RUNNING_TIME)
            {
                resultLabel.Text = StringConstant.TIMES_UP;
                resultLabel.ForeColor = Color.Red;
                return;
            }
            progressBar1.Value = timerInSec;
            log("timer_tick is running.");
        }

    }
}
