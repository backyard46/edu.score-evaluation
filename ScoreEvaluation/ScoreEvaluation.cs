using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScoreEvaluation
{
    public partial class ScoreEvaluation : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreEvaluation"/> class.
        /// </summary>
        public ScoreEvaluation()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 指定されたスコアに応じた色情報を返す。
        /// </summary>
        /// <param name="score">評価対象スコア（整数）</param>
        /// <returns>
        /// スコアに応じた色を表すColor型情報。
        /// </returns>
        private Color EvalScore(int score)
        {
            Color result;

            // スコアに応じて色を決定する
            // switchを使いたいところだが、C#のswitchは条件の範囲指定ができないようなので、If文で。
            if (score == 0)
            {
                result = Color.Red;
            } else if (score>=1 && score<=50)
            {
                result = Color.Orange;
            }
            else if (score >= 51 && score <= 80)
            {
                result = Color.Yellow;
            }
            else if (score >= 81 && score <= 100)
            {
                result = Color.Green;
            }
            else
            {
                result = Color.White;
            }
            return result;
        }

        /// <summary>
        /// 社員1のスコア入力欄Leave処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void TextScore1_Leave(object sender, EventArgs e)
        {
            if (TextScore1.Text != String.Empty)
            {
                TextScore1.BackColor = EvalScore(int.Parse(TextScore1.Text));
            }
        }

        /// <summary>
        /// 社員1のスコア入力欄Enter押下時処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void TextScore1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TextScore1.Text != String.Empty)
                {
                    TextScore1.BackColor = EvalScore(int.Parse(TextScore1.Text));
                }
            }
        }

        /// <summary>
        /// 社員2のスコア入力欄Leave処理。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextScore2_Leave(object sender, EventArgs e)
        {
            if (TextScore2.Text != String.Empty)
            {
                TextScore2.BackColor = EvalScore(int.Parse(TextScore2.Text));
            }
        }

        /// <summary>
        /// 社員2のスコア入力欄Enter押下時処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void TextScore2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TextScore2.Text != String.Empty)
                {
                    TextScore2.BackColor = EvalScore(int.Parse(TextScore2.Text));
                }
            }
        }

        /// <summary>
        /// 社員3のスコア入力欄Leave処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void TextScore3_Leave(object sender, EventArgs e)
        {
            if (TextScore3.Text != String.Empty)
            {
                TextScore3.BackColor = EvalScore(int.Parse(TextScore3.Text));
            }
        }

        /// <summary>
        /// 社員3のスコア入力欄Enter押下時処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void TextScore3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TextScore3.Text != String.Empty)
                {
                    TextScore3.BackColor = EvalScore(int.Parse(TextScore3.Text));
                }
            }
        }

        /// <summary>
        /// 社員4のスコア入力欄Leave処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void TextScore4_Leave(object sender, EventArgs e)
        {
            if (TextScore4.Text != String.Empty)
            {
                TextScore4.BackColor = EvalScore(int.Parse(TextScore4.Text));
            }
        }

        /// <summary>
        /// 社員4のスコア入力欄Enter押下時処理。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void TextScore4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TextScore4.Text != String.Empty)
                {
                    TextScore4.BackColor = EvalScore(int.Parse(TextScore4.Text));
                }
            }
        }
    }
}
