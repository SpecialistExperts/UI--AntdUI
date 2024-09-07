// COPYRIGHT (C) Tom. ALL RIGHTS RESERVED.
// THE AntdUI PROJECT IS AN WINFORM LIBRARY LICENSED UNDER THE Apache-2.0 License.
// LICENSED UNDER THE Apache License, VERSION 2.0 (THE "License")
// YOU MAY NOT USE THIS FILE EXCEPT IN COMPLIANCE WITH THE License.
// YOU MAY OBTAIN A COPY OF THE LICENSE AT
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// UNLESS REQUIRED BY APPLICABLE LAW OR AGREED TO IN WRITING, SOFTWARE
// DISTRIBUTED UNDER THE LICENSE IS DISTRIBUTED ON AN "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, EITHER EXPRESS OR IMPLIED.
// SEE THE LICENSE FOR THE SPECIFIC LANGUAGE GOVERNING PERMISSIONS AND
// LIMITATIONS UNDER THE License.
// GITEE: https://gitee.com/antdui/AntdUI
// GITHUB: https://github.com/AntdUI/AntdUI
// CSDN: https://blog.csdn.net/v_132
// QQ: 17379620

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Overview
{
    public partial class Main : AntdUI.Window
    {
        public Main(bool top)
        {
            InitializeComponent();
            TopMost = top;
            colorTheme.ValueChanged += ColorTheme_ValueChanged;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            DraggableMouseDown();
            base.OnMouseDown(e);
        }

        private void ItemClick(object sender, AntdUI.VirtualItemEventArgs e) => OpenPage(e.Item.Tag.ToString());

        Form FloatButton = null;
        public void OpenPage(string id)
        {
            //virtualPanel.BlurBar = windowBar;
            //virtualPanel.ScrollBar.ValueY = 3150;
            //AntdUI.ITask.Run(() =>
            //{
            //    System.Threading.Thread.Sleep(100);
            //    virtualPanel.BlurBar = null;
            //    virtualPanel.ScrollBar.ValueY = 2821;
            //});
            //return;
            Control control_add = null;
            switch (id)
            {
                case "Button":
                    control_add = new Controls.Button(this);
                    break;
                case "Icon":
                    control_add = new Controls.Icon(this);
                    break;
                case "Avatar":
                    control_add = new Controls.Avatar(this);
                    break;
                case "Carousel":
                    control_add = new Controls.Carousel(this);
                    break;
                case "Badge":
                    control_add = new Controls.Badge(this);
                    break;
                case "Checkbox":
                    control_add = new Controls.Checkbox(this);
                    break;
                case "Radio":
                    control_add = new Controls.Radio(this);
                    break;
                case "Input":
                    control_add = new Controls.Input(this);
                    break;
                case "Select":
                    control_add = new Controls.Select(this);
                    break;
                case "Panel":
                    control_add = new Controls.Panel(this);
                    break;
                case "Progress":
                    control_add = new Controls.Progress(this);
                    break;
                case "Result":
                    control_add = new Controls.Result(this);
                    break;
                case "Tooltip":
                    control_add = new Controls.Tooltip(this);
                    break;
                case "Divider":
                    control_add = new Controls.Divider(this);
                    break;
                case "Slider":
                    control_add = new Controls.Slider(this);
                    break;
                case "Tabs":
                    control_add = new Controls.Tabs(this);
                    break;
                case "Switch":
                    control_add = new Controls.Switch(this);
                    break;
                case "Pagination":
                    control_add = new Controls.Pagination(this);
                    break;
                case "Alert":
                    control_add = new Controls.Alert(this);
                    break;
                case "Message":
                    control_add = new Controls.Message(this);
                    break;
                case "Notification":
                    control_add = new Controls.Notification(this);
                    break;
                case "Menu":
                    control_add = new Controls.Menu(this);
                    break;
                case "Segmented":
                    control_add = new Controls.Segmented(this);
                    break;
                case "Modal":
                    control_add = new Controls.Modal(this);
                    break;
                case "DatePicker":
                    control_add = new Controls.DatePicker(this);
                    break;
                case "TimePicker":
                    control_add = new Controls.TimePicker(this);
                    break;
                case "Dropdown":
                    control_add = new Controls.Dropdown(this);
                    break;
                case "Tree":
                    control_add = new Controls.Tree(this);
                    break;
                case "Popover":
                    control_add = new Controls.Popover(this);
                    break;
                case "Timeline":
                    control_add = new Controls.Timeline(this);
                    break;
                case "Steps":
                    control_add = new Controls.Steps(this);
                    break;
                case "ColorPicker":
                    control_add = new Controls.ColorPicker(this);
                    break;
                case "InputNumber":
                    control_add = new Controls.InputNumber(this);
                    break;
                case "Tag":
                    control_add = new Controls.Tag(this);
                    break;
                case "Drawer":
                    control_add = new Controls.Drawer(this);
                    break;
                case "FloatButton":
                    FloatButton?.Close();
                    FloatButton = AntdUI.FloatButton.open(new AntdUI.FloatButton.Config(this, new AntdUI.FloatButton.ConfigBtn[] {
                        new AntdUI.FloatButton.ConfigBtn("id1", "SearchOutlined", true){
                            Tooltip = "搜索一下",
                            Type= AntdUI.TTypeMini.Primary
                        },
                        new AntdUI.FloatButton.ConfigBtn("id2", Properties.Resources.img1){
                            Badge = " ",
                            Tooltip = "笑死人",
                        },
                        new AntdUI.FloatButton.ConfigBtn("id3",Properties.Resources.icon_like, true){
                            Badge = "9",
                            Tooltip = "救救我"
                        },
                        new AntdUI.FloatButton.ConfigBtn("id4", "PoweroffOutlined", true){
                            Badge = "99+",
                            Tooltip = "没救了",
                            Round = false,
                            Type= AntdUI.TTypeMini.Primary
                        }
                    }, btn =>
                    {
                        AntdUI.Message.info(this, "点击了：" + btn.Name, Font);
                    }));
                    break;
                case "Rate":
                    control_add = new Controls.Rate(this);
                    break;
                case "Table":
#if DEBUG
                    control_add = new Controls.Table(this);
#else
                    control_add = new Controls.TableAOT(this);
#endif
                    break;
                case "Image":
                    control_add = new Controls.Preview(this);
                    break;
                case "VirtualPanel":
                    control_add = new Controls.VirtualPanel(this);
                    break;
                case "PageHeader":
                    control_add = new Controls.PageHeader(this);
                    break;
                case "Breadcrumb":
                    control_add = new Controls.Breadcrumb(this);
                    break;
            }
            if (control_add != null)
            {
                if (windowBar.Tag is Control control)
                {
                    control.Dispose();
                    Controls.Remove(control);
                }
                windowBar.Tag = control_add;
                BeginInvoke(new Action(() =>
                {
                    virtualPanel.Visible = false;
                    control_add.Dock = DockStyle.Fill;
                    AutoDpi(control_add);
                    Controls.Add(control_add);
                    control_add.BringToFront();
                    control_add.Focus();
                    windowBar.ShowBack = true;
                }));
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                if (windowBar.Tag is Control control)
                {
                    control.Dispose();
                    Controls.Remove(control);
                }
                windowBar.ShowBack = false;
                virtualPanel.Visible = true;
            }));
        }

        private void btn_mode_Click(object sender, EventArgs e)
        {
            var color = AntdUI.Style.Db.Primary;
            AntdUI.Config.IsDark = !AntdUI.Config.IsDark;
            Dark = AntdUI.Config.IsDark;
            AntdUI.Style.Db.SetPrimary(color);
            if (Dark)
            {
                btn_mode.IconSvg = Properties.Resources.app_dark;
                BackColor = Color.Black;
                ForeColor = Color.White;
            }
            else
            {
                btn_mode.IconSvg = Properties.Resources.app_light;
                BackColor = Color.White;
                ForeColor = Color.Black;
            }
            OnSizeChanged(e);
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            var setting = new Setting(this);
            if (AntdUI.Modal.open(this, "设置", setting) == DialogResult.OK)
            {
                AntdUI.Config.Animation = setting.Animation;
                AntdUI.Config.ShadowEnabled = setting.ShadowEnabled;
                AntdUI.Config.ShowInWindow = setting.ShowInWindow;
                AntdUI.Config.ScrollBarHide = setting.ScrollBarHide;
            }
        }

        private void ColorTheme_ValueChanged(object sender, AntdUI.ColorEventArgs e)
        {
            AntdUI.Style.Db.SetPrimary(e.Value);
            Refresh();
        }

        #region 搜索

        private void txt_search_PrefixClick(object sender, MouseEventArgs e) => LoadSearchList();

        private void txt_search_TextChanged(object sender, EventArgs e) => LoadSearchList();

        void LoadSearchList()
        {
            string search = txt_search.Text;
            windowBar.Loading = true;
            BeginInvoke(new Action(() =>
            {
                virtualPanel.PauseLayout = true;
                if (string.IsNullOrEmpty(search))
                {
                    foreach (var it in virtualPanel.Items) it.Visible = true;
                    virtualPanel.Empty = false;
                }
                else
                {
                    virtualPanel.Empty = true;
                    string searchLower = search.ToLower();
                    var titles = new List<TItem>(virtualPanel.Items.Count);
                    foreach (var it in virtualPanel.Items)
                    {
                        if (it is VItem item) it.Visible = item.data.id.Contains(search) || item.data.key.Contains(search) || item.data.keyword.Contains(searchLower) || item.data.keywordmini.Contains(searchLower);
                        else if (it is TItem itemTitle) titles.Add(itemTitle);
                    }
                    foreach (var it in titles)
                    {
                        int count = 0;
                        foreach (var item in it.data)
                        {
                            if (item.Visible) count++;
                        }
                        it.Visible = count > 0;
                    }
                }
                virtualPanel.PauseLayout = false;
                windowBar.Loading = false;
            }));
        }

        #endregion

        #region 加载列表

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            windowBar.Loading = true;
            AntdUI.ITask.Run(LoadList);
        }

        void LoadList()
        {
            IList[] dir_General = new IList[]
            {
                //通用
                new IList("Button","按钮", res_light.Button, res_dark.Button),
                new IList("FloatButton","悬浮按钮",res_light.FloatButton, res_dark.FloatButton),
                new IList("Icon","图标",res_light.Icon, res_dark.Icon)
            },
            dir_Layout = new IList[]
            {
                //布局
                new IList("Divider","分割线", res_light.Divider, res_dark.Divider)
            },
            dir_Navigation = new IList[]
            {
                //导航
                new IList("Breadcrumb","面包屑", res_light.Breadcrumb, res_dark.Breadcrumb),
                new IList("Dropdown","下拉菜单", res_light.Dropdown, res_dark.Dropdown),
                new IList("Menu","导航菜单", res_light.Menu, res_dark.Menu),
                new IList("PageHeader","页头",res_light.PageHeader, res_dark.PageHeader),
                new IList("Pagination","分页",res_light.Pagination, res_dark.Pagination),
                new IList("Steps","步骤条",res_light.Steps, res_dark.Steps)
            },
            dir_DataEntry = new IList[]
            {
                //数据录入
                new IList("Checkbox","多选框", res_light.Checkbox, res_dark.Checkbox),
                new IList("ColorPicker","颜色选择器", res_light.ColorPicker, res_dark.ColorPicker),
                new IList("DatePicker","日期选择框", res_light.DatePicker, res_dark.DatePicker),
                new IList("Input","输入框", res_light.Input, res_dark.Input),
                new IList("InputNumber","数字输入框", res_light.InputNumber, res_dark.InputNumber),
                new IList("Radio","单选框", res_light.Radio, res_dark.Radio),
                new IList("Rate","评分", res_light.Rate, res_dark.Rate),
                new IList("Select","选择器", res_light.Select, res_dark.Select),
                new IList("Slider","滑动输入条",res_light.Slider, res_dark.Slider),
                new IList("Switch","开关",res_light.Switch, res_dark.Switch),
                new IList("TimePicker","时间选择框",res_light.TimePicker, res_dark.TimePicker)
            },
            dir_DataDisplay = new IList[]
            {
                //数据展示
                new IList("Avatar","头像", res_light.Avatar, res_dark.Avatar),
                new IList("Badge","徽标数",res_light.Badge, res_dark.Badge),
                new IList("Panel","面板", res_light.Panel, res_dark.Panel),
                new IList("Carousel","走马灯",res_light.Carousel, res_dark.Carousel),
                new IList("Collapse","折叠面板",res_light.Collapse, res_dark.Collapse),
                new IList("Image","图片",res_light.Image, res_dark.Image),
                new IList("Popover","气泡卡片",res_light.Popover, res_dark.Popover),
                new IList("Segmented","分段控制器",res_light.Segmented, res_dark.Segmented),
                new IList("Table","表格",res_light.Table, res_dark.Table),
                new IList("Tabs","标签页",res_light.Tabs, res_dark.Tabs),
                new IList("Tag","标签",res_light.Tag, res_dark.Tag),
                new IList("Timeline","时间轴",res_light.Timeline, res_dark.Timeline),
                new IList("Tooltip","文字提示",res_light.Tooltip, res_dark.Tooltip),
                new IList("Tree","树形控件",res_light.Tree, res_dark.Tree)
            },
            dir_Feedback = new IList[]
            {
                //反馈
                new IList("Alert","警告提示",res_light.Alert, res_dark.Alert),
                new IList("Drawer","抽屉",res_light.Drawer, res_dark.Drawer),
                new IList("Message","全局提示",res_light.Message, res_dark.Message),
                new IList("Modal","对话框",res_light.Modal, res_dark.Modal),
                new IList("Notification","通知提醒框",res_light.Notification, res_dark.Notification),
                new IList("Progress","进度条",res_light.Progress, res_dark.Progress),
                new IList("Result","结果",res_light.Result, res_dark.Result)
            };

            var dir = new Dictionary<string, IList[]> {
                { "通用", dir_General },
                { "布局", dir_Layout },
                { "导航", dir_Navigation },
                { "数据录入", dir_DataEntry },
                { "数据展示", dir_DataDisplay },
                { "反馈", dir_Feedback }
            };

            var list = new List<AntdUI.VirtualItem>(dir.Count + dir_General.Length + dir_Layout.Length + dir_Navigation.Length + dir_DataEntry.Length + dir_DataDisplay.Length + dir_Feedback.Length);
            foreach (var it in dir)
            {
                var list_sub = new List<AntdUI.VirtualItem>(it.Value.Length);
                foreach (var item in it.Value) list_sub.Add(new VItem(item));
                list.Add(new TItem(it.Key, list_sub));
                list.AddRange(list_sub);
            }
            virtualPanel.Items.AddRange(list);
            windowBar.Loading = false;
            virtualPanel.BlurBar = windowBar;
        }

        class IList
        {
            public IList(string _id, string _key, string _img_light, string _img_dark)
            {
                id = _id;
                key = _key;
                keyword = _id.ToLower() + AntdUI.Pinyin.GetPinyin(_key).ToLower();
                keywordmini = AntdUI.Pinyin.GetInitials(_key).ToLower();
                imgs = new Image[] { AntdUI.SvgExtend.SvgToBmp(_img_light), AntdUI.SvgExtend.SvgToBmp(_img_dark) };
            }
            public string id { get; set; }
            public string keyword { get; set; }
            public string keywordmini { get; set; }
            public string key { get; set; }
            public Image[] imgs { get; set; }
        }

        class TItem : AntdUI.VirtualItem
        {
            string title, count;
            public List<AntdUI.VirtualItem> data;
            public TItem(string t, List<AntdUI.VirtualItem> d)
            {
                CanClick = false;
                data = d;
                title = t;
                count = d.Count.ToString();
            }

            StringFormat s_f = AntdUI.Helper.SF_NoWrap(lr: StringAlignment.Near);
            StringFormat s_c = AntdUI.Helper.SF_NoWrap();
            public override void Paint(Graphics g, AntdUI.VirtualPanelArgs e)
            {
                var dpi = AntdUI.Config.Dpi;

                using (var fore = new SolidBrush(AntdUI.Style.Db.Text))
                {
                    int x = (int)(30 * dpi);
                    using (var font_title = new Font(e.Panel.Font, FontStyle.Bold))
                    using (var font_count = new Font(e.Panel.Font.FontFamily, e.Panel.Font.Size * .74F, e.Panel.Font.Style))
                    {
                        var size = AntdUI.Helper.Size(g.MeasureString(title, font_title));
                        AntdUI.CorrectionTextRendering.DrawStr(g, title, font_title, fore, new Rectangle(e.Rect.X + x, e.Rect.Y, e.Rect.Width, e.Rect.Height), s_f);

                        var rect_count = new Rectangle(e.Rect.X + x + size.Width, e.Rect.Y + (e.Rect.Height - size.Height) / 2, size.Height, size.Height);
                        using (var path = AntdUI.Helper.RoundPath(rect_count, e.Radius))
                        {
                            using (var brush = new SolidBrush(AntdUI.Style.Db.TagDefaultBg))
                            {
                                g.FillPath(brush, path);
                            }
                            using (var pen = new Pen(AntdUI.Style.Db.DefaultBorder, 1 * dpi))
                            {
                                g.DrawPath(pen, path);
                            }
                        }
                        AntdUI.CorrectionTextRendering.DrawStr(g, count, font_count, fore, rect_count, s_c);
                    }
                }
            }

            public override Size Size(Graphics g, AntdUI.VirtualPanelArgs e)
            {
                var dpi = AntdUI.Config.Dpi;
                return new Size(e.Rect.Width, (int)(44 * dpi));
            }
        }

        class VItem : AntdUI.VirtualShadowItem
        {
            public IList data;
            public VItem(IList d) { data = d; Tag = d.id; }


            StringFormat s_f = new StringFormat { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Near };
            public override void Paint(Graphics g, AntdUI.VirtualPanelArgs e)
            {
                var dpi = AntdUI.Config.Dpi;
                int title_height = (int)(44 * dpi), thickness = (int)(1 * dpi), size = (int)(10 * dpi), size2 = size * 2;
                using (var brush = new SolidBrush(AntdUI.Style.Db.BgContainer))
                {
                    using (var path = AntdUI.Helper.RoundPath(e.Rect, e.Radius))
                    {
                        g.FillPath(brush, path);
                        using (var brush_bor = new Pen(Hover ? AntdUI.Style.Db.BorderColorDisable : AntdUI.Style.Db.BorderColor, thickness))
                        {
                            g.DrawPath(brush_bor, path);
                        }
                    }
                }
                using (var fore = new SolidBrush(AntdUI.Style.Db.Text))
                {
                    using (var font_title = new Font(e.Panel.Font.FontFamily, 11F, FontStyle.Bold))
                    {
                        AntdUI.CorrectionTextRendering.DrawStr(g, data.id + " " + data.key, font_title, fore, new Rectangle(e.Rect.X + size2, e.Rect.Y, e.Rect.Width - size2, title_height), s_f);
                    }
                }
                using (var brush = new SolidBrush(AntdUI.Style.Db.Split))
                {
                    g.FillRectangle(brush, new RectangleF(e.Rect.X + size, e.Rect.Y + title_height - thickness / 2F, e.Rect.Width - size2, thickness));
                }
                var bmp = AntdUI.Config.IsDark ? data.imgs[1] : data.imgs[0];
                g.DrawImage(bmp, e.Rect.X + (e.Rect.Width - bmp.Width) / 2, (e.Rect.Y + title_height) + ((e.Rect.Height - title_height) - bmp.Height) / 2, bmp.Width, bmp.Height);
            }

            public override Size Size(Graphics g, AntdUI.VirtualPanelArgs e)
            {
                var dpi = AntdUI.Config.Dpi;
                return new Size((int)(258 * dpi), (int)(244 * dpi));
            }
        }

        #endregion
    }
}