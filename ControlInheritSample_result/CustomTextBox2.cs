using System;
using System.Drawing;
using System.Windows.Forms;

namespace ControlInheritResult
{
    /// <summary>
    /// 文字入力時だけ太字になるテキストボックス。
    /// </summary>
    /// <seealso cref="System.Windows.Forms.TextBox" />
    public class CustomTextBox2 : TextBox
    {
        // 事前にフォント情報を用意しておく。
        // コントロール自体Fontプロパティの中身はReadonlyのため部分的な書き換えができない。
        // そのため、各設定に応じたFont情報自体を作っておいてFontごと差し替える。
        private Font defaultFont = new Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
        private Font altFont = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));

        // ※フォント指定に「今のフォントをそのままに、太字にする」といった場合
        // 　new Font(this.Font, FontStyle.Bold);
        // 　という記法でフォントオブジェクトを生成することもできます。ただし、その場合、
        // 　thisはメソッドの中でしか使えないため上記の方法ではなく、テキストボックス生成時に
        // 　実行される「OnCreateControl」などでフォントオブジェクトの生成を行ってください。


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
