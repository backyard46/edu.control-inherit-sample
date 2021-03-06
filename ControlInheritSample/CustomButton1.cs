using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlInherit
{
    /// <summary>
    /// 押すたびに色が変わるボタン。
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Button" />
    public class CustomButton1 : Button
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
            // 自分自身（ボタン）は「this」で指し示すことができるので、「this.プロパティ名」で
            // プロパティを書き換えれば色を変える事が出来ます。

        }
    }
}
