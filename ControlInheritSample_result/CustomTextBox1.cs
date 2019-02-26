using System;
using System.Drawing;
using System.Windows.Forms;

namespace ControlInheritResult
{
    /// <summary>
    /// 課題3: マウスカーソルが上を通過するときだけ色が変わるテキストボックス。
    /// </summary>
    /// <seealso cref="System.Windows.Forms.TextBox" />
    public class CustomTextBox1 : TextBox
    {
        /// <summary>
        /// マウスカーソルが上に来たときの処理。
        /// </summary>
        /// <param name="e">イベント データを格納している <see cref="T:System.EventArgs" />。</param>
        protected override void OnMouseEnter(EventArgs e)
        {
            // 最初に「本来のテキストボックスが行うべきMouseEnter処理」を実行する。
            base.OnMouseEnter(e);
            // テキストボックス背景色を変更。
            this.BackColor = Color.Aqua;
        }

        /// <summary>
        /// マウスカーソルが外れたときの処理。
        /// </summary>
        /// <param name="e">イベント データを格納している <see cref="T:System.EventArgs" />。</param>
        protected override void OnMouseLeave(EventArgs e)
        {
            // 最初に「本来のテキストボックスが行うべきMouseLeave処理」を実行する。
            base.OnMouseLeave(e);
            // テキストボックス背景色を戻す。元々の色はSystemColors.Window。
            this.BackColor = SystemColors.Window;
        }
    }
}
