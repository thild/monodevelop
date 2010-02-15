
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.Ide.Gui.OptionPanels
{
	internal partial class BuildMessagePanelWidget
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Label label6;

		private global::Gtk.ComboBox comboboxJumpToFirst;

		private global::Gtk.Label label7;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Label label8;

		private global::Gtk.Table table2;

		private global::Gtk.ComboBox comboboxBuildResultsAfter;

		private global::Gtk.ComboBox comboboxBuildResultsDuring;

		private global::Gtk.Label label1;

		private global::Gtk.Label label2;

		private global::Gtk.Label label9;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Label label10;

		private global::Gtk.Table table3;

		private global::Gtk.ComboBox comboboxErrorPadAfter;

		private global::Gtk.ComboBox comboboxErrorPadDuring;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gtk.Label label11;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label label12;

		private global::Gtk.Label label5;

		private global::Gtk.ComboBox comboboxMessageBubbles;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.Ide.Gui.OptionPanels.BuildMessagePanelWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.Ide.Gui.OptionPanels.BuildMessagePanelWidget";
			// Container child MonoDevelop.Ide.Gui.OptionPanels.BuildMessagePanelWidget.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.Xalign = 0f;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Jump to first error or warning:");
			this.hbox1.Add (this.label6);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label6]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.comboboxJumpToFirst = global::Gtk.ComboBox.NewText ();
			this.comboboxJumpToFirst.AppendText (global::Mono.Unix.Catalog.GetString ("Never"));
			this.comboboxJumpToFirst.Name = "comboboxJumpToFirst";
			this.comboboxJumpToFirst.Active = 0;
			this.hbox1.Add (this.comboboxJumpToFirst);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.comboboxJumpToFirst]));
			w2.Position = 1;
			this.vbox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.Xalign = 0f;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Build Results Window</b>");
			this.label7.UseMarkup = true;
			this.vbox1.Add (this.label7);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label7]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("    ");
			this.hbox3.Add (this.label8);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.label8]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.comboboxBuildResultsAfter = global::Gtk.ComboBox.NewText ();
			this.comboboxBuildResultsAfter.AppendText (global::Mono.Unix.Catalog.GetString ("Never"));
			this.comboboxBuildResultsAfter.Name = "comboboxBuildResultsAfter";
			this.comboboxBuildResultsAfter.Active = 0;
			this.table2.Add (this.comboboxBuildResultsAfter);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table2[this.comboboxBuildResultsAfter]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.comboboxBuildResultsDuring = global::Gtk.ComboBox.NewText ();
			this.comboboxBuildResultsDuring.AppendText (global::Mono.Unix.Catalog.GetString ("Never"));
			this.comboboxBuildResultsDuring.Name = "comboboxBuildResultsDuring";
			this.comboboxBuildResultsDuring.Active = 0;
			this.table2.Add (this.comboboxBuildResultsDuring);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table2[this.comboboxBuildResultsDuring]));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0f;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Show during build:");
			this.table2.Add (this.label1);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table2[this.label1]));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 0f;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Show after build:");
			this.table2.Add (this.label2);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table2[this.label2]));
			w9.TopAttach = ((uint)(1));
			w9.BottomAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox3.Add (this.table2);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.table2]));
			w10.Position = 1;
			this.vbox1.Add (this.hbox3);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox3]));
			w11.Position = 2;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.Xalign = 0f;
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Errors and Warnings Pad</b>");
			this.label9.UseMarkup = true;
			this.vbox1.Add (this.label9);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label9]));
			w12.Position = 3;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label10 = new global::Gtk.Label ();
			this.label10.Name = "label10";
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("    ");
			this.hbox4.Add (this.label10);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label10]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.table3 = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			// Container child table3.Gtk.Table+TableChild
			this.comboboxErrorPadAfter = global::Gtk.ComboBox.NewText ();
			this.comboboxErrorPadAfter.AppendText (global::Mono.Unix.Catalog.GetString ("Never"));
			this.comboboxErrorPadAfter.Name = "comboboxErrorPadAfter";
			this.comboboxErrorPadAfter.Active = 0;
			this.table3.Add (this.comboboxErrorPadAfter);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table3[this.comboboxErrorPadAfter]));
			w14.TopAttach = ((uint)(1));
			w14.BottomAttach = ((uint)(2));
			w14.LeftAttach = ((uint)(1));
			w14.RightAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.comboboxErrorPadDuring = global::Gtk.ComboBox.NewText ();
			this.comboboxErrorPadDuring.AppendText (global::Mono.Unix.Catalog.GetString ("Never"));
			this.comboboxErrorPadDuring.Name = "comboboxErrorPadDuring";
			this.comboboxErrorPadDuring.Active = 0;
			this.table3.Add (this.comboboxErrorPadDuring);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table3[this.comboboxErrorPadDuring]));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 0f;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Show after build:");
			this.table3.Add (this.label3);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table3[this.label3]));
			w16.TopAttach = ((uint)(1));
			w16.BottomAttach = ((uint)(2));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 0f;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Show during build:");
			this.table3.Add (this.label4);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table3[this.label4]));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox4.Add (this.table3);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.table3]));
			w18.Position = 1;
			this.vbox1.Add (this.hbox4);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox4]));
			w19.Position = 4;
			w19.Expand = false;
			w19.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label11 = new global::Gtk.Label ();
			this.label11.Name = "label11";
			this.label11.Xalign = 0f;
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Message Bubbles</b>");
			this.label11.UseMarkup = true;
			this.vbox1.Add (this.label11);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label11]));
			w20.Position = 5;
			w20.Expand = false;
			w20.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label12 = new global::Gtk.Label ();
			this.label12.Name = "label12";
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("    ");
			this.hbox2.Add (this.label12);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label12]));
			w21.Position = 0;
			w21.Expand = false;
			w21.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 0f;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Show during build:");
			this.hbox2.Add (this.label5);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label5]));
			w22.Position = 1;
			w22.Expand = false;
			w22.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.comboboxMessageBubbles = global::Gtk.ComboBox.NewText ();
			this.comboboxMessageBubbles.AppendText (global::Mono.Unix.Catalog.GetString ("Never"));
			this.comboboxMessageBubbles.Name = "comboboxMessageBubbles";
			this.comboboxMessageBubbles.Active = 0;
			this.hbox2.Add (this.comboboxMessageBubbles);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.comboboxMessageBubbles]));
			w23.Position = 2;
			this.vbox1.Add (this.hbox2);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
			w24.Position = 6;
			w24.Expand = false;
			w24.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}