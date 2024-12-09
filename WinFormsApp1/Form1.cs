namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int count = 0;
            string[] arr= { "Меня зовут Михаил Фастаковский", "Я студент ITStep University", "Почти full-stack)))" };

            for (int i = 0; i < arr.Length; i++) {
                count += arr[i].Replace(" ", "").Length;
                if (i == 2)
                {
                    MessageBox.Show(arr[i], (count/arr.Length).ToString(), MessageBoxButtons.OK);
                    continue;
                }
                MessageBox.Show(arr[i], "", MessageBoxButtons.OK);
              
              
            }
            Random rnd = new Random();
            bool isFinish = true;
            while (isFinish ==true) {
                do
                {
                    DialogResult = MessageBox.Show($"Ваше число - {rnd.Next(1, 2000)}", "Угадай число", MessageBoxButtons.YesNo);
                } while (DialogResult != DialogResult.Yes);
                DialogResult = MessageBox.Show("Хотите продолжить?", "Угадай число", MessageBoxButtons.YesNo);

                if (DialogResult == DialogResult.No)
                {
                    isFinish = false;
                }
            }
            this.Close();
      



        }
    }
}
