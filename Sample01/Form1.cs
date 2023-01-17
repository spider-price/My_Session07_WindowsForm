using Sample01.LifeCycle;

namespace Sample01
{
    public partial class Form1 : Form
    {
        TrainingClass trainingClass = new();
        int RDB_Check_Number = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;


            switch (button.Name)
            {

                case "Btn_Manager_Save":


                    if (Txt_Manager_Id.Text.Length > 0 &&
                        Txt_Manager_FName.Text.Length > 0 &&
                        Txt_Manager_LName.Text.Length > 0)
                    {

                        #region [-trainingClass.Manager(Id,FirstName,LastName)-]
                        trainingClass.Manager.Id = Convert.ToInt32(Txt_Manager_Id.Text);
                        trainingClass.Manager.FirstName = Txt_Manager_FName.Text;
                        trainingClass.Manager.LastName = Txt_Manager_LName.Text; 
                        #endregion


                        #region [-Txt_Manager(Clear)-]
                        Txt_Manager_Id.Clear();
                        Txt_Manager_FName.Clear();
                        Txt_Manager_LName.Clear(); 
                        #endregion


                        Btn_Manager_Save.Enabled = false;


                        #region [-Btn_Print.Enabled-]
                        if (Btn_Manager_Save.Enabled == false &&
                                          Btn_Teacher_Save.Enabled == false &&
                                          Btn_Student_Save.Enabled == false)
                            Btn_Print.Enabled = true; 
                        #endregion
                    }

                    else
                        MessageBox.Show("fill the text boxes");


                    break;


                case "Btn_Teacher_Save":
                    if (Txt_Teacher_Id.Text.Length > 0 &&
                        Txt_Teacher_FName.Text.Length > 0 &&
                        Txt_Teacher_LName.Text.Length > 0)
                    {
                        #region [-trainingClass.Teacher(Id,FirstName,LastName)-]
                        trainingClass.Teacher.Id = Convert.ToInt32(Txt_Teacher_Id.Text);
                        trainingClass.Teacher.FirstName = Txt_Teacher_FName.Text;
                        trainingClass.Teacher.LastName = Txt_Teacher_FName.Text; 
                        #endregion


                        #region [-Txt_Teacher(Clear)-]
                        Txt_Teacher_Id.Clear();
                        Txt_Teacher_FName.Clear();
                        Txt_Teacher_LName.Clear(); 
                        #endregion

                        Btn_Teacher_Save.Enabled = false;


                        #region [-Btn_Print.Enabled = true-]
                        if (Btn_Manager_Save.Enabled == false &&
                           Btn_Teacher_Save.Enabled == false &&
                           Btn_Student_Save.Enabled == false)

                           Btn_Print.Enabled = true; 
                        #endregion
                    }


                    else
                        MessageBox.Show("fill the text boxes");


                    break;


                case "Btn_Student_Save":

                    if (Txt_Student_Id.Text.Length > 0 &&
                        Txt_Student_FName.Text.Length > 0 &&
                        Txt_Student_LName.Text.Length > 0)
                    {

                        #region [-RDB_Checked-]
                        if (RDB_1.Checked == true)
                        {
                            Btn_Student_Save.Enabled = false;
                        }

                        else if (RDB_2.Checked == true)
                        {
                            RDB_Check_Number++;

                            if (RDB_Check_Number == 2)
                            {
                                Btn_Student_Save.Enabled = false;
                            }
                        }
                        else if (RDB_3.Checked == true)
                        {
                            RDB_Check_Number++;

                            if (RDB_Check_Number == 3)
                            {
                                Btn_Student_Save.Enabled = false;
                            }
                        }
                        #endregion


                        #region [-Students(List)-]
                        trainingClass.Students = new List<Student>()
                    {
                    new Student(){Id = Convert.ToInt32(Txt_Student_Id.Text),
                     FirstName = Txt_Student_FName.Text,
                     LastName = Txt_Student_LName.Text},
                     
                     new Student(){Id = Convert.ToInt32(Txt_Student_Id.Text),
                     FirstName = Txt_Student_FName.Text,
                     LastName = Txt_Student_LName.Text},

                     new Student(){Id = Convert.ToInt32(Txt_Student_Id.Text),
                     FirstName = Txt_Student_FName.Text,
                     LastName = Txt_Student_LName.Text}
                    };
                        #endregion


                        #region [-Txt_Student(Clear)-]
                        Txt_Student_Id.Clear();
                        Txt_Student_FName.Clear();
                        Txt_Student_LName.Clear();
                        #endregion


                        #region [-Btn_Print.Enabled-]
                        if (Btn_Manager_Save.Enabled == false &&
                           Btn_Teacher_Save.Enabled == false &&
                           Btn_Student_Save.Enabled == false)

                           Btn_Print.Enabled = true; 
                        #endregion

                    }


                    else
                        MessageBox.Show("fill the text boxes");


                    break;


                case "Btn_Print":

                    Txt_Show_Result.Show();
                    Btn_Print.Hide();


                    #region [-Txt_Show_Result.Text-]
                    Txt_Show_Result.Text +=
                                   $"manager:{trainingClass.Manager.FullName}\n" +
                                   $"teacher:{trainingClass.Teacher.FullName}\n";

                    foreach (var item in trainingClass.Students)
                    {
                        Txt_Show_Result.Text +=
                        $"student: id({item.Id}),full name({item.FullName})\n";
                    } 
                    #endregion


                    break;
            }
        }

        private void Id_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}