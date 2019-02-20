using System;
using System.Windows.Forms;

namespace ControlInheritSample
{
    /// <summary>
    /// 課題3: マウスカーソルが上を通過するときだけ色が変わるテキストボックス。
    /// </summary>
    /// <seealso cref="System.Windows.Forms.TextBox" />
    class CustomTextBox1 : TextBox
    {
        /// <summary>
        /// マウスカーソルが上に来たときの処理。
        /// </summary>
        /// <param name="e">イベント データを格納している <see cref="T:System.EventArgs" />。</param>
        protected override void OnMouseEnter(EventArgs e)
        {
            // 最初に「本来のテキストボックスが行うべきMouseEnter処理」を実行する。
            base.OnMouseEnter(e);

            // ここに、自分の色を変える処理を書いてください。
        }

        /// <summary>
        /// マウスカーソルが外れたときの処理。
        /// </summary>
        /// <param name="e">イベント データを格納している <see cref="T:System.EventArgs" />。</param>
        protected override void OnMouseLeave(EventArgs e)
        {
            // 最初に「本来のテキストボックスが行うべきMouseLeave処理」を実行する。
            base.OnMouseLeave(e);

            // ここに、自分の色を元に戻す処理を書いてください。
        }
    }
}
