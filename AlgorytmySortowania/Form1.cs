using AlgorytmySortowania.Records;
using AlgorytmySortowania.SortingAlgorithms;

namespace AlgorytmySortowania
{
    public sealed partial class Form1 : Form
    {
        private List<int> list = new();
        public Form1()
        {
            InitializeComponent();

            textBox1.PlaceholderText = "Dodaj liczbę do listy";

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DisplayMember = nameof(SortOption.Name);

            comboBox1.DataSource = new List<SortOption>             
            {
                new ("Bubble Sort", BubbleSort.Sort),
                new ("Selection Sort", SelectSort.Sort)
            };

            comboBox1.SelectedIndex = 0;
        }

        private void B_Add_Click(object sender, EventArgs e)
        {
            AddNumberFromTextToList(textBox1.Text, out list);
            L_ToSort.Items.Clear();

            foreach (var number in list)
            {
                L_ToSort.Items.Add(number);
            }
        }

        private void AddNumberFromTextToList(string input, out List<int> output)
        {
            output = new List<int>();
            var listString = input.Split(new[] { ',', ' ', ';' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in listString)
            {
                int number;

                if(!int.TryParse(item, out number))
                {
                    MessageBox.Show($"Nieprawidłowa liczba: {item}");
                    continue;
                }

                output.Add(number);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void L_ToSort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void B_Sort_Click(object sender, EventArgs e)
        {
            List<int> sortedList;

            if (comboBox1.SelectedItem is not SortOption option)
            {
                MessageBox.Show("Wybierz algorytm sortowania.");
                return;
            }

            option.Sort(list, out sortedList);

            DisplayNumbersInListBox(sortedList);
        }

        private void DisplayNumbersInListBox(List<int> list)
        {
            L_Sorted.Items.Clear();
            foreach (int number in list)
            {
                L_Sorted.Items.Add(number);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
