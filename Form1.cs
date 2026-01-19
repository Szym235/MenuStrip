using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuScript
{
    public partial class Form1 : Form
    {
        int selectedTaskIndex = -1;
        String path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "tasksSaveFile.txt");
        public Form1()
        {
            Console.WriteLine(path);
            InitializeComponent();
            addTaskGroupBox.BringToFront();
            editTaskGroupBox.Location = addTaskGroupBox.Location;
            deleteTaskGroupBox.Location = addTaskGroupBox.Location;
            loadTasks();
        }

        private void addTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addTaskGroupBox.BringToFront();
            resetTaskAddMenu();
        }

        private void addTaskToolStripButton_Click(object sender, EventArgs e)
        {
            addTaskGroupBox.BringToFront();
            resetTaskAddMenu();
        }

        private void newTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addTaskGroupBox.BringToFront();
            resetTaskAddMenu();
        }

        private void resetTaskAddMenu()
        {
            addTaskNameRichTextBox.Text = "";
            addTaskDescriptionRichTextBox.Text = "";
            addTaskPriorityComboBox.SelectedIndex = -1;
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            if (addTaskNameRichTextBox.Text == "")
            {
                MessageBox.Show("Nie wpisano nazwy zadania.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (addTaskDescriptionRichTextBox.Text == "")
            {
                MessageBox.Show("Nie wpisano opisu zadania.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (addTaskPriorityComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Nie wybrano priorytetu zadania.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                foreach (ListViewItem item in tasksListView.Items)
                {
                    if (item.SubItems[0].Text == addTaskNameRichTextBox.Text)
                    {
                        MessageBox.Show("Zadanie o takiej nazwie już istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

            String taskName = addTaskNameRichTextBox.Text;
            String taskDescription = addTaskDescriptionRichTextBox.Text;
            String taskPriority = addTaskPriorityComboBox.SelectedItem.ToString();
            DateTime taskDueDate = addTaskDateTimePicker.Value;

            ListViewItem newItem = new ListViewItem(new string[] {
                taskName,
                taskDescription,
                taskPriority,
                taskDueDate.ToString(),
            });
            tasksListView.Items.Add(newItem);

            resetTaskAddMenu();
        }


        private void editTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editTaskGroupBox.BringToFront();

            editTaskDescriptionRichTextBox.Text = "";
            editTaskDescriptionRichTextBox.Enabled = false;
            editTaskPriorityComboBox.Enabled = false;
            editTaskDateTimePicker.Enabled = false;

            setupNameComboBox(editTaskNameComboBox);
        }

        private void taskForEditComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (sender as ComboBox);
            selectedTaskIndex = comboBox.SelectedIndex;
            if (selectedTaskIndex != -1)
            {
                ListViewItem listViewItem = tasksListView.Items[selectedTaskIndex];

                editTaskDescriptionRichTextBox.Enabled = true;
                editTaskDescriptionRichTextBox.Text = listViewItem.SubItems[1].Text;

                editTaskPriorityComboBox.Enabled = true;
                editTaskPriorityComboBox.SelectedItem = listViewItem.SubItems[2].Text;

                editTaskDateTimePicker.Enabled = true;
                editTaskDateTimePicker.Value = DateTime.Parse(listViewItem.SubItems[3].Text);

                editTaskButton.Enabled = true;
            }
        }

        private void editTaskButton_Click(object sender, EventArgs e)
        {
            tasksListView.Items[selectedTaskIndex].SubItems[1].Text = editTaskDescriptionRichTextBox.Text;
            tasksListView.Items[selectedTaskIndex].SubItems[2].Text = editTaskPriorityComboBox.SelectedItem.ToString();
            tasksListView.Items[selectedTaskIndex].SubItems[3].Text = editTaskDateTimePicker.Value.ToShortDateString();
        }

        private void deleteTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteTaskGroupBox.BringToFront();
            resetTaskDeleteMenu();
        }

        private void deleteTaskToolStripButton_Click(object sender, EventArgs e)
        {
            deleteTaskGroupBox.BringToFront();
            resetTaskDeleteMenu();
        }

        private void resetTaskDeleteMenu()
        {
            setupNameComboBox(deleteTaskNameComboBox);
            deleteTaskDescriptionRichTextBox.Text = "";
            deleteTaskPriorityTextBox.Text = "";
            deleteTaskDateTextBox.Text = "";
            deleteTaskButton.Enabled = false;
        }

        private void setupNameComboBox(ComboBox comboBox)
        {
            comboBox.SelectedIndex = -1;
            if (tasksListView.Items.Count == 0)
            {
                comboBox.Enabled = false;
            }
            else
            {
                comboBox.Items.Clear();
                String[] allNames = new String[tasksListView.Items.Count];
                foreach (ListViewItem item in tasksListView.Items)
                {
                    allNames[item.Index] = item.SubItems[0].Text;
                }
                comboBox.Items.AddRange(allNames);
                comboBox.Enabled = true;
            }
        }

        private void deleteTaskNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (sender as ComboBox);
            selectedTaskIndex = comboBox.SelectedIndex;
            if (selectedTaskIndex != -1)
            {
                ListViewItem listViewItem = tasksListView.Items[selectedTaskIndex];

                deleteTaskDescriptionRichTextBox.Text = listViewItem.SubItems[1].Text;
                deleteTaskPriorityTextBox.Text = listViewItem.SubItems[2].Text;
                deleteTaskDateTextBox.Text = listViewItem.SubItems[3].Text;

                deleteTaskButton.Enabled = true;
            }
        }

        private void deleteTaskButton_Click(object sender, EventArgs e)
        {
            tasksListView.Items.RemoveAt(selectedTaskIndex);
            resetTaskDeleteMenu();
        }

        private void closeAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeApp();
        }

        private void closeAppStripButton_Click(object sender, EventArgs e)
        {
            closeApp();
        }

        private void closeApp()
        {
            DialogResult result = MessageBox.Show("Czy na pewno chcesz zamknąć aplikację?",
                "Zamykanie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                saveTasks();
                Application.Exit();
            }
        }

        private void saveTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveTasks();
        }
        private void saveTasksToolStripButton_Click(object sender, EventArgs e)
        {
            saveTasks();
        }

        private void saveTasks()
        {
            if(File.Exists(path)) File.Delete(path);
            File.Create(path).Close();

            StreamWriter writer = new StreamWriter(path);
            foreach(ListViewItem item in tasksListView.Items)
            {
                String line = String.Join(",", new string[] {
                    item.SubItems[0].Text,
                    item.SubItems[1].Text,
                    item.SubItems[2].Text,
                    item.SubItems[3].Text,
                });
                writer.WriteLine(line);
            }
            writer.Close();
            MessageBox.Show("Zapisano listę zadań", "Zapis", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void loadTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadTasks();
        }

        private void loadTasks()
        {
            if (!File.Exists(path)) return;
            StreamReader reader = new StreamReader(path);

            tasksListView.Items.Clear();
            String line;
            while ((line = reader.ReadLine()) != null)
            {
                String[] parts = line.Split(',');
                ListViewItem newItem = new ListViewItem(new string[] {
                    parts[0],
                    parts[1],
                    parts[2],
                    parts[3],
                });
                tasksListView.Items.Add(newItem);
            }
            MessageBox.Show("Wczytano listę zadań", "Wczytanie ukończone", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reader.Close();
        }

        private void giveInfo()
        {
            MessageBox.Show("Aplikacja stworzona przez Szymona Gościniewicz z klasy 4J\n", "Informacje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void pomocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            giveInfo();
        }

        private void informacjeOProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            giveInfo();
        }
    }
}
