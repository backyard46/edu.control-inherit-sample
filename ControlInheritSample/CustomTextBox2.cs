using System;
using System.Windows.Forms;

namespace ControlInherit
{
    /// <summary>
    /// 課題3: マウスカーソルが上を通過するときだけ色が変わるテキストボックス。
    /// </summary>
    /// <seealso cref="System.Windows.Forms.TextBox" />
    class CustomTextBox2 : TextBox
    {
        /// <summary>
        /// テキストボックスにフォーカスが移動した際の処理。
        /// </summary>
        /// <param name="e">イベント データを格納している <see cref="T:System.EventArgs" />。</param>
        protected override void OnEnter(EventArgs e)
        {
            // 最初に「本来のテキストボックスが行うべきEnter処理」を実行する。
            base.OnEnter(e);
        }

        /// <summary>
        /// テキストボックスからフォーカスが移動した際の処理。
        /// </summary>
        /// <param name="e">イベント データを格納している <see cref="T:System.EventArgs" />。</param>
        protected override void OnLeave(EventArgs e)
        {
            // 最初に「本来のテキストボックスが行うべきLeave処理」を実行する。
            base.OnLeave(e);
        }
    }
}
