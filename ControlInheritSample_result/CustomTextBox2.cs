using System;
using System.Drawing;
using System.Windows.Forms;

namespace ControlInheritResult
{
    /// <summary>
    /// 課題3: マウスカーソルが上を通過するときだけ色が変わるテキストボックス。
    /// </summary>
    /// <seealso cref="System.Windows.Forms.TextBox" />
    class CustomTextBox2 : TextBox
    {
        private Font defaultFont, altFont;

        /// <summary>
        /// コントロール生成時の初期処理。
        /// </summary>
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            // 事前にフォント情報を用意しておく。
            // コントロール自体Fontプロパティの中身はReadonlyのため部分的な書き換えができない。
            // そのため、各設定に応じたFont情報自体を作っておいてFontごと差し替える。
            defaultFont = new Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            altFont = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
        }

        /// <summary>
        /// テキストボックスにフォーカスが移動した際の処理。
        /// </summary>
        /// <param name="e">イベント データを格納している <see cref="T:System.EventArgs" />。</param>
        protected override void OnEnter(EventArgs e)
        {
            // 最初に「本来のテキストボックスが行うべきEnter処理」を実行する。
            base.OnEnter(e);
            // 太字設定のフォントに切り替える。
            this.Font = altFont;
        }

        /// <summary>
        /// テキストボックスからフォーカスが移動した際の処理。
        /// </summary>
        /// <param name="e">イベント データを格納している <see cref="T:System.EventArgs" />。</param>
        protected override void OnLeave(EventArgs e)
        {
            // 最初に「本来のテキストボックスが行うべきLeave処理」を実行する。
            base.OnLeave(e);
            // 事前に用意しておいた「元々のフォント」に戻す。
            this.Font = defaultFont;
        }
    }
}
