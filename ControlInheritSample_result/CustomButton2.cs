using System;
using System.Windows.Forms;

namespace ControlInheritResult
{
    /// <summary>
    /// 課題2: 押すたびに表面の文字が「年月日」→「時分秒」に変わるボタン。
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Button" />
    public class CustomButton2 : Button
    {
        /// <summary>
        /// コントロールが初期表示された時の処理。
        /// </summary>
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            // 初期表示時に年月日を表示したい場合、OnCreateControlに処理を書けばOKです。
            this.Text = DateTime.Now.ToLongDateString();
        }

        /// <summary>
        /// ボタンがクリックされた際の処理。
        /// </summary>
        /// <param name="e">イベント データを格納している <see cref="T:System.EventArgs" />。</param>
        protected override void OnClick(EventArgs e)
        {
            // 最初に「本来のボタンが行うべきクリック処理」を実行する。
            base.OnClick(e);

            // ここに、自分の色を変える処理を書いてください。
            if (this.Text.Contains("日"))
            {
                // 文字列に「日」が入っていたら、時刻表示に切り替える
                this.Text = DateTime.Now.ToLongTimeString();
            }
            else
            {
                // 日付表示に切り替える
                this.Text = DateTime.Now.ToLongDateString();
            }
        }
    }
}
