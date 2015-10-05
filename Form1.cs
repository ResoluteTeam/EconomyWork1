using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                double amount = 0;
                double amount_full = 0;
                double balance_cost = 0;
                double reserve_fund = 0;
                double net_profit = 0;
                double net_profit_full = 0;
                double borrowed_money = 0;
                double borrowed_money_full;
                double involved_money = 0;
                double involved_money_full;
                double accumulation_fund = 0;
                double accumulation_fund_full = 0;
                double offered_shares = 0;
                double offered_shares_full = 0;
                double sales_shares = 0;
                double sales_shares_full = 0;

                //  #1
                double value_per_share = 0;
                //  #2
                double balance_cost_of_one_share = 0;
                double capitalized_value_of_the_shares = 0;
                // #3
                double ratio_of_the_value_of_shares = 0;
                // #4
                double absolute_amount_of_interest = 0;
                double profit_per_share = 0;
                // #5
                double dividend_per_share = 0;
                // #6
                double dividend_return_of_shares = 0;
                // #7
                double total_shareholder_return = 0;
                // #8
                double coefficients_liquidity_of_shares = 0;
                // #9
                double coefficients_circulation_of_shares = 0;


        string samount = textBox1.Text;
        string sbalance_cost = textBox3.Text;

        string sreserve_fund = textBox4.Text;
        string snet_profit = textBox5.Text;

        string sborrowed_money = textBox6.Text;
        string sinvolved_money = textBox7.Text;

        string saccumulation_fund = textBox8.Text;
        string soffered_shares = textBox9.Text;

        string ssales_shares = textBox10.Text;
        

        //string b = Convert.ToString(i);
        //label1.Text = b;
        try
        {
            amount = Convert.ToDouble(samount);
            amount_full = amount * 1000;
            balance_cost = Convert.ToDouble(sbalance_cost);
            reserve_fund = Convert.ToDouble(sreserve_fund);
            net_profit = Convert.ToDouble(snet_profit);
            net_profit_full = net_profit * 1000;
            borrowed_money = Convert.ToDouble(sborrowed_money);
            borrowed_money_full = borrowed_money * 1000;
            involved_money = Convert.ToDouble(sinvolved_money);
            involved_money_full = involved_money / 100;
            accumulation_fund = Convert.ToDouble(saccumulation_fund);
            accumulation_fund_full = accumulation_fund / 100;
            offered_shares = Convert.ToDouble(soffered_shares);
            offered_shares_full = offered_shares * 1000;
            sales_shares = Convert.ToDouble(ssales_shares);
            sales_shares_full = sales_shares * 1000;

            //                        throw new Exception("WTF");
            //                        MessageBox.Show("D = " + d);
            //label9.Text = "K1_C sht1 = " + Convert.ToString(k1_csht1);
            //MessageBox.Show("a" + amount + "\nb" + balance_cost+ "\nr" + reserve_fund);
            balance_cost_of_one_share = (balance_cost + reserve_fund) / amount;
            label11.Text = "Balance cost of one share = " + balance_cost_of_one_share;


            value_per_share = balance_cost_of_one_share * amount / 100;
            label12.Text = "Value per share = " + value_per_share;

            capitalized_value_of_the_shares = value_per_share * amount_full;
            label13.Text = "Capitalized value of the shares = " + capitalized_value_of_the_shares;

            ratio_of_the_value_of_shares = value_per_share / balance_cost_of_one_share;
            label14.Text = "Ratio of the value of shares = " + ratio_of_the_value_of_shares;


            absolute_amount_of_interest = borrowed_money_full * involved_money_full;
            label15.Text = "Absolute amount of interest = " + absolute_amount_of_interest;
            profit_per_share = (net_profit_full - absolute_amount_of_interest) / amount_full;
            label16.Text = "Profit per share = " + profit_per_share;


            dividend_per_share = (net_profit_full - absolute_amount_of_interest - (net_profit_full - absolute_amount_of_interest) * accumulation_fund_full) / amount_full;
            label17.Text = "Divedend per share = " + dividend_per_share;

            // #6
            dividend_return_of_shares = dividend_per_share / value_per_share;
            label18.Text = "Divident return of share = " + dividend_return_of_shares;

            // #7
            total_shareholder_return = (value_per_share - balance_cost_of_one_share) + dividend_per_share;
            label19.Text = "Total shareholder return = " + total_shareholder_return;

            coefficients_liquidity_of_shares = offered_shares_full / sales_shares_full;
            label20.Text = "Coefficients liquidity of shares = " + coefficients_liquidity_of_shares;
            // #9
            coefficients_circulation_of_shares = sales_shares_full / capitalized_value_of_the_shares;
            label21.Text = "Coefficients circulation of shares = " + coefficients_circulation_of_shares;

        }

        catch (FormatException)
        {
            MessageBox.Show("Неккоректный ввод \n Повторите, плз, еще раз");
        }

        catch (OverflowException)
        {
            MessageBox.Show("What is number? Over 900000000?\n ahaha\n Stop trolling me");
        }

        /*               catch (Exception WTF)
                       {
                           MessageBox.Show("D < 0... \nSo, soso");
                       } */


    }

        }
    }
}
