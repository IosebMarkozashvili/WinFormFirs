using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Db;
using WindowsFormsApp2.Model;
using WindowsFormsApp2.Repos;
using WindowsFormsApp2.Validation;
using static WindowsFormsApp2.Validation.Validator;

namespace WindowsFormsApp2
{
    public partial class l : Form
    {
        ApplicationDbContext db;
        Repository Repos;
        public l()
        {
            InitializeComponent();
            db = new ApplicationDbContext();
            Repos = new Repository();


            using (ApplicationDbContext Db = new ApplicationDbContext())
            {
              
                dis(Db.Users.ToList());

            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            try
            {
                var name = Repos.RemoveWhitespace(NameBox.Text);
                var age = Convert.ToInt32(Repos.RemoveWhitespace(AgeBox.Text));
                var surname = Repos.RemoveWhitespace(SurNameBox.Text);
                User user = new User() { Name = name, Age = age, Surname = surname, ID = 0 };
                var validator = new Validator();
                if (user != null)
                {
                    CustomerValidator validationRules = new CustomerValidator();
                    ValidationResult validationResult = validationRules.Validate(user);
                    IList<ValidationFailure> validationFailures = validationResult.Errors;
                    if (!validationResult.IsValid)
                    {
                        foreach (var i in validationFailures)
                        {
                            MessageBox.Show(i.ErrorMessage, "Error Message");
                        }
                    }
                    if (validationResult.IsValid)
                    {
                        MessageBox.Show($"Succes", "true");

                        using (ApplicationDbContext Db = new ApplicationDbContext())
                        {
                            Db.Users.Add(user);
                           Db.SaveChanges();
                            dis(Db.Users.ToList());

                        }

                        //Empty();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"გთხოვთ სწორედ შემოიტანოთ ინფორმაცია");
            }

        }
        public void Empty()
        {
            NameBox.Text = "";
            SurNameBox.Text = "";

            AgeBox.Text = "";
            IDBox.Text = "";
        }

        public void dis(List<User> collection)
        {
            //DataRow dataRow = dt.NewRow();


            DataTable dt = new DataTable();
            DtTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dt.Columns.Add("Id");
            dt.Columns.Add("Name");
            dt.Columns.Add("Surname");
            dt.Columns.Add("Age");
            for (var i = 0; i < collection.Count; i++)
            {

                DataRow dataRow = dt.NewRow();

                dataRow[0] = collection[i].ID;

                dataRow[1] = collection[i].Name;
                dataRow[2] = collection[i].Surname;
                dataRow[3] = collection[i].Age;
                dt.Rows.Add(dataRow);
                DtTable.DataSource = dt;


            }


        }

        private void DtTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DtTable.CurrentRow.Selected = true;
                DtTable.CurrentRow.ReadOnly = false;
                DtTable.Rows[e.RowIndex].ReadOnly = true;


                DtTable.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.Green;
                AgeBox.Text = DtTable.Rows[e.RowIndex].Cells["Age"].Value.ToString();
                SurNameBox.Text = DtTable.Rows[e.RowIndex].Cells["Surname"].Value.ToString();
                NameBox.Text = DtTable.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                IDBox.Text = DtTable.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                foreach (DataGridViewRow row in DtTable.SelectedRows)
                {
                    DtTable.RowsDefaultCellStyle.SelectionBackColor = row.DefaultCellStyle.BackColor;
                }


            }
            catch
            {

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
           

                using (ApplicationDbContext Db = new ApplicationDbContext())
                {
                    try
                    {
                     
                        var ID = Convert.ToInt32(Repos.RemoveWhitespace(IDBox.Text));
                        var user = Db.Users.ToList().FirstOrDefault(o => o.ID == ID);
                        if (user != null)
                        {
                            Db.Users.Remove(user);
                            Db.SaveChanges();
                           
                             Empty();
                        }
                        if(db.Users.ToList().Count == 0)
                    {

                        MessageBox.Show("ამოიწურა");
                    }
                      
                    }
                    catch (Exception ex)
                    {

                    
                        MessageBox.Show("არმოიძებნა");
                           

                        }
                dis(Db.Users.ToList());

            }
            
           
        }

        private void NameSearch_TextChanged(object sender, EventArgs e)
        {
            using (ApplicationDbContext Db = new ApplicationDbContext())
                {
             var exist =  Db.Users.ToList().Where(o => o.Name.Contains(NameSearch.Text)).ToList();
                if(exist == null)
                {
                    dis(new List<User>());
                }
                dis(exist);
                }
        }
      //  ???
        private void UpdateBox_Click(object sender, EventArgs e)
        {
            using (ApplicationDbContext Db = new ApplicationDbContext())
            {
                try
                {
                    var ID = Convert.ToInt32(Repos.RemoveWhitespace(IDBox.Text));

                    var name = Repos.RemoveWhitespace(NameBox.Text);
                    var age = Convert.ToInt32(Repos.RemoveWhitespace(AgeBox.Text));
                    var surname = Repos.RemoveWhitespace(SurNameBox.Text);
                    User user = new User() { Name = name, Age = age, Surname = surname, ID = 0 };
                    var validator = new Validator();
                   
                        CustomerValidator validationRules = new CustomerValidator();
                        ValidationResult validationResult = validationRules.Validate(user);
                        IList<ValidationFailure> validationFailures = validationResult.Errors;
                        if (!validationResult.IsValid)
                        {
                            foreach (var i in validationFailures)
                            {
                                MessageBox.Show(i.ErrorMessage, "Error Message");
                            }
                        }
                        if (validationResult.IsValid)
                        {
                            MessageBox.Show($"Succes", "true");
                            var exist = Db.Users.ToList().FirstOrDefault(o => o.ID == ID);
                            if (user != null)
                            {
                                exist.Name = name;
                                exist.Surname = surname;
                                exist.Age = age;
                               
                                Db.SaveChanges();

                                Empty();
                            }

                          
                                Db.SaveChanges();
                                dis(Db.Users.ToList());

                            

                            Empty();
                        }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"გთხოვთ სწორედ შემოიტანოთ ინფორმაცია");
                }
                dis(Db.Users.ToList());

            }
        }

        private void EmptyBox_Click(object sender, EventArgs e)
        {
            Empty();
        }
    }
}
