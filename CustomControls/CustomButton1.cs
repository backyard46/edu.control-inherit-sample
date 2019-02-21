using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlInheritSample
{
    /// <summary>
    /// 課題1: 押すたびに色が変わるボタン。
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Button" />
    class CustomButton1 : Button
    {
        /// <summary>
        /// ボタンがクリックされた際の処理。
        /// </summary>
        /// <param name="e">イベント データを格納している <see cref="T:System.EventArgs" />。</param>
        protected override void OnClick(EventArgs e)
        {
            // 最初に「本来のボタンが行うべきクリック処理」を実行する。
            base.OnClick(e);

            // 初期状態のボタン表面色は「SystemColors.Control」。
            // ボタン押下時の色がこの色かどうかで次の色を決める。
            if (this.BackColor == SystemColors.Control)
            {
                // 初期色の場合は黄色に変える
                this.BackColor = Color.Yellow;
            }
            else
            {
                // 初期色でない場合は初期色に変える
                this.BackColor = SystemColors.Control;
            }
        }
    }
}
