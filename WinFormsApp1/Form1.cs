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
            string[] arr= { "���� ����� ������ ������������", "� ������� ITStep University", "����� full-stack)))" };

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
                    DialogResult = MessageBox.Show($"���� ����� - {rnd.Next(1, 2000)}", "������ �����", MessageBoxButtons.YesNo);
                } while (DialogResult != DialogResult.Yes);
                DialogResult = MessageBox.Show("������ ����������?", "������ �����", MessageBoxButtons.YesNo);

                if (DialogResult == DialogResult.No)
                {
                    isFinish = false;
                }
            }
            this.Close();
      



        }
    }
}
