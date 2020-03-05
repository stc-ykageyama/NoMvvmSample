using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NoMvvmSample
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 「-1」ボタンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDecrement_Clicked(object sender, EventArgs e)
        {
            // 現在のカウンタ値を取得
            var currentNumber = int.Parse(this.counter.Text);

            // 現在のカウンタ値 - 1をラベルに設定
            this.counter.Text = (currentNumber - 1).ToString();
        }

        /// <summary>
        /// 「+1」ボタンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonIncrement_Clicked(object sender, EventArgs e)
        {
            // 現在のカウンタ値を取得
            var currentNumber = int.Parse(this.counter.Text);

            // 現在のカウンタ値 + 1をラベルに設定
            this.counter.Text = (currentNumber + 1).ToString();
        }
    }
}
