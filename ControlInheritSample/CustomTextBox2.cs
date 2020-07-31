using System;
using System.Windows.Forms;

namespace ControlInherit
{
    /// <summary>
    /// 文字入力時だけ太字になるテキストボックス。
    /// </summary>
    /// <seealso cref="System.Windows.Forms.TextBox" />
    public class CustomTextBox2 : TextBox
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
