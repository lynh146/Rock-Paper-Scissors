using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;



namespace Client
{
    public partial class Form1 : Form
    {
        TcpClient client;
        NetworkStream stream;
        int scoreP1 = 0, scoreP2 = 0;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient("127.0.0.1", 5000);
                stream = client.GetStream();
                MessageBox.Show("Connected to Server!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
            }
        }
        private void SendChoice(string choice)
        {
            if (client == null || !client.Connected) return;

            // Gửi lựa chọn
            byte[] data = Encoding.UTF8.GetBytes(choice);
            stream.Write(data, 0, data.Length);

            // Nhận kết quả
            byte[] buffer = new byte[1024];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);

            string[] parts = response.Split('|');
            string result = parts[0];
            string opponentChoice = parts.Length > 1 ? parts[1] : "";

            lblResult.Text = result;
            
            // Ảnh Player 1
            if (choice == "Rock") picPlayer1.Image = Properties.Resources.rock;
            if (choice == "Paper") picPlayer1.Image = Properties.Resources.paper;
            if (choice == "Scissors") picPlayer1.Image = Properties.Resources.scissors;

            // Ảnh Player 2
            if (opponentChoice == "Rock") picPlayer2.Image = Properties.Resources.rock;
            if (opponentChoice == "Paper") picPlayer2.Image = Properties.Resources.paper;
            if (opponentChoice == "Scissors") picPlayer2.Image = Properties.Resources.scissors;

            // Cập nhật điểm
            if (result == "Win") scoreP1++;
            else if (result == "Lose") scoreP2++;

            lblPlayer1Score.Text = $"Player 1: {scoreP1}";
            lblPlayer2Score.Text = $"Player 2: {scoreP2}";
        }
        



        private void btnRock_Click(object sender, EventArgs e) => SendChoice("Rock");


        private void btnPaper_Click(object sender, EventArgs e) => SendChoice("Paper");


        private void btnScissors_Click(object sender, EventArgs e) => SendChoice("Crissors");


        private void btnRestart_Click(object sender, EventArgs e)
        {
            scoreP1 = 0;
            scoreP2 = 0;
            lblPlayer1Score.Text = "Player 1: 0";
            lblPlayer2Score.Text = "Player 2: 0";

            picPlayer1.Image = null;
            picPlayer2.Image = null;
        }
    }

  
}

