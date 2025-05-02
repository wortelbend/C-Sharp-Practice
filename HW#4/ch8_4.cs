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
                // 將字串以逗號分割，並轉成整數陣列
                string input = textBox1.Text;
                string[] parts = input.Split(',');
                int[] numbers = Array.ConvertAll(parts, s => int.Parse(s.Trim()));

                if (numbers.Length != 6)
                {
                    MessageBox.Show("請輸入剛好 6 個數字，用逗號分隔");
                    return;
                }

                int min = arrMin(numbers);
                int max = arrMax(numbers);

                labelResult.Text = "結果:" + $"最小值: {min}，最大值: {max}";
            }
            catch
            {
                MessageBox.Show("請輸入正確的數字格式，例如：12, 5, 33, 9, 71, 18");
            }
        }
    }
}
