using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyBuhin
{
    /// <summary>
    /// 課題1: 押すたびに色が変わるボタン。
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Button" />
    public class YamaneButtom : Button
    {
        /// <summary>
        /// ボタンがクリックされた際の処理。
        /// </summary>
        /// <param name="e">イベント データを格納している <see cref="T:System.EventArgs" />。</param>
        protected override void OnClick(EventArgs e)
        {
            // 最初に「本来のボタンが行うべきクリック処理」を実行する。
            base.OnClick(e);

            // ここに、自分の色を変える処理を書いてください。
            MessageBox.Show("ボタンおしましたね！？");

        }
    }
}
