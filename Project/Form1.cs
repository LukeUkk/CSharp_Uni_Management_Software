using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Project.customersDataSet1;
using System.Threading;

namespace Project
{
    public partial class Form1 : Form
    {
        Thread th;
        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
            



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        
        private void InitializeComboBox()
        {
            
        }
        private void ComboBox1_SelectedIndexChanged(object sender,
        System.EventArgs e)
        {

          
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //save_update cust
        {
            try
            {
                this.Validate();
                this.customersBindingSource.EndEdit();
                this.customersTableAdapter.Update(this.customersDataSet1);
                this.customersDataSet1.AcceptChanges();
                this.customersDataSet1.customers.AcceptChanges();
                this.customersTableAdapter.Fill(this.customersDataSet1.customers);
                MessageBox.Show("Updated");
            }
            catch (System.Exception)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booking_cancelations_dataset1.Cancellations' table. You can move, or remove it, as needed.
            this.cancellationsTableAdapter.Fill(this.booking_cancelations_dataset1.Cancellations);
            // TODO: This line of code loads data into the 'customersDataSet1.customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.customersDataSet1.customers);
            // TODO: This line of code loads data into the 'booking_cancelations_dataset.Bookingtimes' table. You can move, or remove it, as needed.
            this.bookingtimesTableAdapter.Fill(this.booking_cancelations_dataset.Bookingtimes);
            // TODO: This line of code loads data into the 'booking_cancelations_dataset.Bookingtimes' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'booking_cancelations_dataset.Cancellations' table. You can move, or remove it, as needed.
            this.cancellationsTableAdapter.Fill(this.booking_cancelations_dataset.Cancellations);
            // TODO: This line of code loads data into the 'bookingDataSet.Bookingtimes' table. You can move, or remove it, as needed.
            //this.bookingtimesTableAdapter.Fill(this.bookingDataSet.Bookingtimes);
            // TODO: This line of code loads data into the 'customersDataSet.customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.customersDataSet1.customers); 
            // TODO: This line of code loads data into the 'customersDataSet.customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.customersDataSet1.customers);
            // TODO: This line of code loads data into the 'projectchalet11DataSet.Chalet' table. You can move, or remove it, as needed.
            this.chaletTableAdapter.Fill(this.projectchalet11DataSet.Chalet);

        }

        private void htmlToolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //new customer
        {
            try
            {
                this.Validate();
                var rows = this.customersDataSet1.customers.NewcustomersRow();
                rows.Customer_No = Convert.ToInt32(textBox14.Text);
                rows.Title = Titlebox.Text;
                rows.Forname = Forname.Text;
                rows.Surname = SurnameBox3.Text;
                rows.House_No = Convert.ToInt32(HouseNoBox5.Text);
                rows.Address_1 = textBox6.Text;
                rows.Address_2 = textBox7.Text;
                rows.City = citytextbox.Text;
                rows.Postcode = textBox9.Text;
                rows.County = textBox12.Text;
                rows.New_Customer = textBox4.Text; //new customer
                rows.County = textBox10.Text;
                rows.Tel_Number = Convert.ToInt32(textBox11.Text);
                rows.Email = textBox13.Text;
                rows.Chalet_Owner = checkBox1.Checked;

                this.customersDataSet1.customers.Rows.Add(rows);
                this.customersTableAdapter.Update(this.customersDataSet1.customers);
                this.customersDataSet1.customers.AcceptChanges();
                this.customersTableAdapter.Fill(this.customersDataSet1.customers);

                MessageBox.Show("Customer Created");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                MessageBox.Show("Make sure that you have the phone number and house number inputted");
            };
        }
        //this.customersBindingSource.EndEdit(); //issue

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button3_Click(object sender, EventArgs e) //remove customer
        {
            try
            {
                this.Validate();
                this.customersBindingSource.EndEdit();
                this.customersBindingSource.RemoveCurrent();
                this.customersTableAdapter.Update(this.customersDataSet1);
                this.customersDataSet1.customers.AcceptChanges();
                this.customersTableAdapter.Fill(this.customersDataSet1.customers);
                MessageBox.Show("Customer Removed");
            }
            catch 
            {
                MessageBox.Show("Update failed");
            }

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)  //Page 2
        {

        }

        private void label20_Click(object sender, EventArgs e) //lable chalet type
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Forname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addcustbutt_Click(object sender, EventArgs e) // second page booking info add booking
        {
            //try
            //{
                this.Validate();
                //this.customersBindingSource.EndEdit(); //issue
                var rows = this.booking_cancelations_dataset.Bookingtimes.NewBookingtimesRow();
                rows.Customer_No = Convert.ToInt32(comboBox2.Text); //needs changing customernobox is dispaying 
                rows.Booking_ID = Convert.ToInt32(textBox3.Text);
                rows.Deposit_Paid = Depositcheck.Checked;
                rows.Discount = Convert.ToInt32(discount.Text);
                rows.Book_From = Convert.ToDateTime(bookpicker.Text);
                rows.Book_To = Convert.ToDateTime(booktopicker.Text);
                rows.Chalet_choice = chaletchoice.Text;
                rows.Unit_Code = unitBox.Text;
                rows.Price = Convert.ToInt32(pricetextbox.Text);


                this.booking_cancelations_dataset.Bookingtimes.Rows.Add(rows);
                this.bookingtimesTableAdapter.Update(this.booking_cancelations_dataset.Bookingtimes);
                this.booking_cancelations_dataset.Bookingtimes.AcceptChanges();
                this.bookingtimesTableAdapter.Fill(this.booking_cancelations_dataset.Bookingtimes);

            MessageBox.Show("Customer Added");

        }

        private void button4_Click(object sender, EventArgs e)
        {
          //  this.bookingtimesTableAdapter.GetData(this.bookingDataSet.Bookingtimes.)
        }

        private void customersBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
               // this.bookingtimesTableAdapter.FillBy(this.bookingDataSet.Bookingtimes);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
              //  this.bookingtimesTableAdapter.FillBy1(this.bookingDataSet.Bookingtimes);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void discount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click_1(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void update_cust_button_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform(object obj) //runs form
        {
            Application.Run(new Tablee()); //RUNS form
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bookingtimesBindingSource4_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Rembook_button_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.bookingtimesBindingSource.EndEdit();
                this.bookingtimesBindingSource.RemoveCurrent();
                this.bookingtimesTableAdapter.Update(this.booking_cancelations_dataset.Bookingtimes);
                this.booking_cancelations_dataset.Bookingtimes.AcceptChanges();
                this.bookingtimesTableAdapter.Fill(this.booking_cancelations_dataset.Bookingtimes);
                MessageBox.Show("Customer Removed");
            }
            catch
            {
                MessageBox.Show("Update failed");
            }

        }
    }
}
