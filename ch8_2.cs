namespace ch8_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] numbers = new int[5];
            Random rand = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1, 201); // 1~200
            }

            Array.Sort(numbers);

            label1.Text = "�Ƨǫ᪺�}�C�G " + string.Join(", ", numbers);
        }
    }
}
