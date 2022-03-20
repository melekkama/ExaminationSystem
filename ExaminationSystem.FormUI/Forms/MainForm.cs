using ExaminationSystem.BLL.Interfaces;
using ExaminationSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem.FormUI.Forms
{
    public partial class MainForm : Form
    {
        private readonly IGenericService<User> userService;

        public MainForm(IGenericService<User> userService)
        {
            InitializeComponent();
            this.userService = userService;
            Load += MainForm_Load;
        }

        private async void MainForm_Load(object? sender, EventArgs e)
        {
            var users = await userService.GetAllAsync();
            foreach (var user in users)
            {
                listView1.Items.Add(user.Email);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var melek = new User()
            {
                Email = "melekkama_46@hotmail.com",
                FirstName = "Melek",
                LastName = "Kama",
                Passowrd = "12011998"
            };

            await userService.AddAsync(melek);
            await userService.SaveChangesAsync();

        }
    }
}
