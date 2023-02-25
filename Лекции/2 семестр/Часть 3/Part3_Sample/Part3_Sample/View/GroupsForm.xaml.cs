using Part3_Sample.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Part3_Sample.View
{
    /// <summary>
    /// Логика взаимодействия для Groups.xaml
    /// </summary>
    public partial class GroupsForm : Window
    {
        public GroupsForm()
        {
            InitializeComponent();
            dgGroups.ItemsSource = UniversityModel.Instance.Groups.ToArray();
        }

        private void AddGroup1_Click(object sender, RoutedEventArgs e)
        {
            AddGroupForm1 form = new AddGroupForm1();
            if( form.ShowDialog() == true ) {
                var newGroup = form.Group;
                UniversityModel.Instance.Groups.Add(newGroup);
                UniversityModel.Instance.SaveChanges();

                dgGroups.ItemsSource = UniversityModel.Instance.Groups.ToArray();
            }
        }

        private void AddGroup2_Click(object sender, RoutedEventArgs e)
        {
            AddGroupForm2 form = new AddGroupForm2();
            if (form.ShowDialog() == true) {
                var newGroup = form.Group;
                UniversityModel.Instance.Groups.Add(newGroup);
                UniversityModel.Instance.SaveChanges();

                dgGroups.ItemsSource = UniversityModel.Instance.Groups.ToArray();
            }
        }

        private void DeleteGroup1_Click(object sender, RoutedEventArgs e)
        {
            Group selectedGroup = dgGroups.SelectedItem as Group;
            if (selectedGroup == null) {
                MessageBox.Show("Ничего не выбрано!");
                return;
            } else {
                var userChoice = MessageBox.Show($"Вы уверены, что хотите удалить группу {selectedGroup.Name}?", 
                    "Подтвердите удаление", MessageBoxButton.YesNo);
                if(userChoice == MessageBoxResult.Yes) {
                    UniversityModel.Instance.Groups.Remove(selectedGroup);
                    UniversityModel.Instance.SaveChanges();
                    dgGroups.ItemsSource = UniversityModel.Instance.Groups.ToArray();
                }
            }
        }

        private void EditGroup_Click(object sender, RoutedEventArgs e)
        {
            Group selectedGroup = dgGroups.SelectedItem as Group;
            if(selectedGroup == null ) {
                MessageBox.Show("Ничего не выбрано!");
                return;
            }

            AddGroupForm2 form = new AddGroupForm2(selectedGroup);
            if (form.ShowDialog() == true) {
                if( UniversityModel.Instance.Entry(selectedGroup).State == EntityState.Modified) {
                    UniversityModel.Instance.SaveChanges();
                }
            } else {
                //пользователь нажал отмену, обновляем выбранную сущность значениями из БД (если он успел поменять значения каких-то полей)
                UniversityModel.Instance.Entry(selectedGroup).Reload();
            }
            dgGroups.ItemsSource = UniversityModel.Instance.Groups.ToArray();
        }

        private void AddGroupWithValidationRule_Click(object sender, RoutedEventArgs e)
        {
            AddGroupWithValidationRuleForm form = new AddGroupWithValidationRuleForm();
            if (form.ShowDialog() == true) {
                var newGroup = form.Group;
                UniversityModel.Instance.Groups.Add(newGroup);
                UniversityModel.Instance.SaveChanges();

                dgGroups.ItemsSource = UniversityModel.Instance.Groups.ToArray();
            }

        }

        private void AddGroupWithDataErrorInfo_Click(object sender, RoutedEventArgs e)
        {
            AddGroupWithDataErrorInfoForm form = new AddGroupWithDataErrorInfoForm();
            form.ShowDialog();
        }

        private void AddGroupWithAttributes_Click(object sender, RoutedEventArgs e)
        {
            AddGroupWithAttributesForm form = new AddGroupWithAttributesForm();
            if (form.ShowDialog() == true) {
                var newGroup = form.Group;
                UniversityModel.Instance.Groups.Add(newGroup);
                UniversityModel.Instance.SaveChanges();
                dgGroups.ItemsSource = UniversityModel.Instance.Groups.ToArray();
            }
        }
    }
}
