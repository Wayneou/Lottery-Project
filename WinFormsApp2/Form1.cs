using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkPrizeButton.Enabled = false;  //還沒開獎，所以還不能兌獎，讓兌獎按鈕變成不能按的狀態
        }

        private void signButton_Click(object sender, EventArgs e)
        {
            // 獲取第一區選擇的號碼
            string firstAreaSelectedNumber = groupBoxFirstArea.Controls
                .OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked)?.Text;

            // 確保第一區有選擇
            if (string.IsNullOrEmpty(firstAreaSelectedNumber))
            {
                MessageBox.Show("請選擇第一區的號碼。");
                return;
            }

            // 獲取第二區選擇的號碼
            var secondAreaSelectedNumbers = groupBoxSecondArea.Controls
                .OfType<CheckBox>()
                .Where(c => c.Checked)
                        .Select(c => int.Parse(c.Text))
        .OrderBy(n => n) // 這裡對選中的號碼進行排序
                .ToList();

            // 確保第二區選擇了 6 個號碼
            if (secondAreaSelectedNumbers.Count != 6)
            {
                MessageBox.Show("請在第二區選擇 6 個號碼。");
                return;
            }

            // 將選擇的號碼添加到 DataGridView
            dataGridViewSignedNumbers.Rows.Add(
                firstAreaSelectedNumber,
                string.Join(", ", secondAreaSelectedNumbers),
                "尚未兌獎", // 兌獎狀況初始值
                "尚未兌獎"  // 中獎金額初始值
            );

            // 清除選擇以供下一次簽牌
            ClearSelections();
        }


        //撰寫清除的函式
        private void ClearSelections()
        {
            // 清除第一區的單選按鈕選擇
            foreach (var radioButton in groupBoxFirstArea.Controls.OfType<RadioButton>())
            {
                radioButton.Checked = false;
            }

            // 清除第二區的復選框選擇
            foreach (var checkBox in groupBoxSecondArea.Controls.OfType<CheckBox>())
            {
                checkBox.Checked = false;
            }
        }

        private void packageButton_Click(object sender, EventArgs e)
        {
            // 獲取第一區選擇的號碼
            string firstAreaSelectedNumber = groupBoxFirstArea.Controls
                .OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked)?.Text;

            // 確保第一區有選擇
            if (string.IsNullOrEmpty(firstAreaSelectedNumber))
            {
                MessageBox.Show("請選擇第一區的號碼。");
                return;
            }

            // 產生第二區所有可能的號碼組合並添加到 DataGridView
            List<int> allNumbers = Enumerable.Range(1, 38).ToList(); // 生成 01 到 38 的號碼列表
            var combinations = GetCombinations(allNumbers, 6); // 獲取所有的 6 個號碼的組合

            foreach (var combo in combinations)
            {
                dataGridViewSignedNumbers.Rows.Add(
                    firstAreaSelectedNumber.PadLeft(2, '0'),
                    string.Join(" ", combo.Select(n => n.ToString().PadLeft(2, '0'))),
                    "尚未兌獎", // 兌獎狀況初始值
                    "尚未兌獎"  // 中獎金額初始值
                );
            }
        }

        private Random rng = new Random(); // 實例化 Random 對象

        private void randomSelectButton_Click(object sender, EventArgs e)
        {
            // 獲取第一區選擇的號碼
            string firstAreaSelectedNumber = groupBoxFirstArea.Controls
                .OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked)?.Text;

            // 確保第一區有選擇
            if (string.IsNullOrEmpty(firstAreaSelectedNumber))
            {
                MessageBox.Show("請選擇第一區的號碼。");
                return;
            }

            // 生成並添加10組隨機號碼  這裡設定500組1~38取6，不重複
            for (int i = 0; i < 500; i++)
            {
                var randomNumbers = GenerateRandomNumbers(1, 38, 6);
                dataGridViewSignedNumbers.Rows.Add(
                    firstAreaSelectedNumber.PadLeft(2, '0'),
                    string.Join(" ", randomNumbers.Select(n => n.ToString().PadLeft(2, '0'))),
                    "尚未兌獎",
                    "尚未兌獎"
                );
            }
        }


        // 生成一組不重複的隨機數並排序
        private List<int> GenerateRandomNumbers(int min, int max, int count)
        {
            return Enumerable.Range(min, max - min + 1).OrderBy(_ => rng.Next()).Take(count).OrderBy(n => n).ToList();
        }




        //今日頭獎號碼生成
        private void generatePrizeButton_Click(object sender, EventArgs e)
        {
            // 產生第一區的號碼
            int firstAreaPrizeNumber = rng.Next(1, 9); // 第一區號碼範圍是 01 到 08
            labelFirstAreaPrize.Text = firstAreaPrizeNumber.ToString().PadLeft(2, '0');

            // 產生第二區的號碼
            var secondAreaPrizeNumbers = GenerateRandomNumbers(1, 38, 6);
            labelSecondAreaPrize.Text = string.Join(" ", secondAreaPrizeNumbers.Select(n => n.ToString().PadLeft(2, '0')));


            checkPrizeButton.Enabled = true;//開獎了，所以可以按兌獎，讓兌獎按鈕變成可以按的狀態
        }




        // 使用遞迴方法來獲取所有可能的組合
        public static IEnumerable<IEnumerable<T>> GetCombinations<T>(IEnumerable<T> list, int length)
        {
            if (length == 1) return list.Select(t => new T[] { t });
            return GetCombinations(list, length - 1)
                .SelectMany(t => list.Where(o => !t.Contains(o)),
                            (t1, t2) => t1.Concat(new T[] { t2 }));
        }

        //判斷用戶簽牌號碼的中獎狀況和計算獎金，參考台灣彩券的規定
        private (string, int) CheckPrize(int[] userNumbers, int[] winningNumbers, int userSpecialNumber, int winningSpecialNumber)
        {
            label6.Text = "已經兌獎";
            int matchedNumbers = userNumbers.Intersect(winningNumbers).Count();
            bool specialNumberMatch = userSpecialNumber == winningSpecialNumber;

            if (matchedNumbers == 6 && specialNumberMatch)
                return ("頭獎", 100000000);
            if (matchedNumbers == 6)
                return ("貳獎", 1000000);
            if (matchedNumbers == 5 && specialNumberMatch)
                return ("參獎", 150000);
            if (matchedNumbers == 5)
                return ("肆獎", 20000);
            if (matchedNumbers == 4 && specialNumberMatch)
                return ("伍獎", 4000);
            if (matchedNumbers == 4)
                return ("陸獎", 800);
            if (matchedNumbers == 3 && specialNumberMatch)
                return ("柒獎", 400);
            if (matchedNumbers == 2 && specialNumberMatch)
                return ("捌獎", 200);
            if (matchedNumbers == 3)
                return ("玖獎", 100);
            if (matchedNumbers == 1 && specialNumberMatch)
                return ("普獎", 100);

            return ("未中獎", 0);
        }





        private void checkPrizeButton_Click(object sender, EventArgs e)
        {
            // 從label中讀取今日頭獎中第一區以及第二區的文字
            int[] winningNumbers = labelSecondAreaPrize.Text.Split(' ').Select(int.Parse).ToArray();
            int winningSpecialNumber = int.Parse(labelFirstAreaPrize.Text);

            foreach (DataGridViewRow row in dataGridViewSignedNumbers.Rows)
            {
                if (row.IsNewRow)
                {
                    continue; // 跳過新行
                }

                var secondAreaCell = row.Cells["SecondArea"].Value;
                var firstAreaCell = row.Cells["FirstArea"].Value;

                if (secondAreaCell == null || firstAreaCell == null)
                {
                    // 避免出現沒有開獎的問題
                    MessageBox.Show("存在空的值");
                    continue;
                }

                int[] userNumbers = secondAreaCell.ToString().Split(' ').Select(int.Parse).ToArray();
                int userSpecialNumber = int.Parse(firstAreaCell.ToString());

                var (prizeStatus, prizeAmount) = CheckPrize(userNumbers, winningNumbers, userSpecialNumber, winningSpecialNumber);

                row.Cells["PrizeStatus"].Value = prizeStatus;
                row.Cells["PrizeAmount"].Value = prizeAmount.ToString("C0"); // 格式化为货币显示，不带小数点
            }

            // 刷新 DataGridView 以显示最新数据
            dataGridViewSignedNumbers.Refresh();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearSelections();

            // 清除所有标签文本
            labelFirstAreaPrize.Text = "未開獎";
            labelSecondAreaPrize.Text = "未開獎";
            label6.Text = "是否按過兌獎";

            // 清空 DataGridView
            dataGridViewSignedNumbers.Rows.Clear();
            checkPrizeButton.Enabled = false;
        }
    }

}