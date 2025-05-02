namespace ch8_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int arrMin(int[] arr)
        {
            int min = arr[0];
            foreach (int num in arr)
            {
                if (num < min)
                    min = num;
            }
            return min;
        }

        int arrMax(int[] arr)
        {
            int max = arr[0];
            foreach (int num in arr)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // �N�r��H�r�����ΡA���ন��ư}�C
                string input = textBox1.Text;
                string[] parts = input.Split(',');
                int[] numbers = Array.ConvertAll(parts, s => int.Parse(s.Trim()));

                if (numbers.Length != 6)
                {
                    MessageBox.Show("�п�J��n 6 �ӼƦr�A�γr�����j");
                    return;
                }

                int min = arrMin(numbers);
                int max = arrMax(numbers);

                labelResult.Text = "���G:" + $"�̤p��: {min}�A�̤j��: {max}";
            }
            catch
            {
                MessageBox.Show("�п�J���T���Ʀr�榡�A�Ҧp�G12, 5, 33, 9, 71, 18");
            }
        }
    }
}
