using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlInherit
{
    /// <summary>
    /// 押すたびに表面の文字が「年月日」→「時分秒」に変わるボタン。
    /// 1回押すと表示が「時分秒」に切り替わり、もう一度押すと「年月日」に切り替わります。
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Button" />
    public class CustomButton2 : Button
    {
        /// <summary>
        /// ボタンがクリックされた際の処理。
        /// </summary>
        /// <param name="e">イベント データを格納している <see cref="T:System.EventArgs" />。</param>
        protected override void OnClick(EventArgs e)
        {
            // 最初に「本来のボタンが行うべきクリック処理」を実行する。
            base.OnClick(e);

            // ここに、ボタン表面の文字を書き換える処理を書いてください。
            

        }
    }
}
