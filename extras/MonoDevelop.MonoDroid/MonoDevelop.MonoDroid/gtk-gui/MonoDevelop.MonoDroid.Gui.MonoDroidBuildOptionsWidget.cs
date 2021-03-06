
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.MonoDroid.Gui
{
	public partial class MonoDroidBuildOptionsWidget
	{
		private global::Gtk.Notebook notebook1;
		private global::Gtk.Table table1;
		private global::Gtk.Entry extraMonoDroidArgsEntry;
		private global::Gtk.HBox hbox1;
		private global::Gtk.ComboBox linkerCombo;
		private global::Gtk.Label label1;
		private global::Gtk.Label label2;
		private global::Gtk.CheckButton sharedRuntimeCheck;
		private global::Gtk.Label label3;
		private global::Gtk.VBox vbox2;
		private global::Gtk.Label label5;
		private global::Gtk.Alignment alignment1;
		private global::Gtk.VBox vbox3;
		private global::Gtk.Label label6;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TreeView i18NTreeView;
		private global::Gtk.Label label4;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.MonoDroid.Gui.MonoDroidBuildOptionsWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.MonoDroid.Gui.MonoDroidBuildOptionsWidget";
			// Container child MonoDevelop.MonoDroid.Gui.MonoDroidBuildOptionsWidget.Gtk.Container+ContainerChild
			this.notebook1 = new global::Gtk.Notebook ();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 1;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.table1 = new global::Gtk.Table (((uint)(4)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.extraMonoDroidArgsEntry = new global::Gtk.Entry ();
			this.extraMonoDroidArgsEntry.CanFocus = true;
			this.extraMonoDroidArgsEntry.Name = "extraMonoDroidArgsEntry";
			this.extraMonoDroidArgsEntry.IsEditable = true;
			this.extraMonoDroidArgsEntry.InvisibleChar = '●';
			this.table1.Add (this.extraMonoDroidArgsEntry);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1 [this.extraMonoDroidArgsEntry]));
			w1.TopAttach = ((uint)(2));
			w1.BottomAttach = ((uint)(3));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			// Container child hbox1.Gtk.Box+BoxChild
			this.linkerCombo = global::Gtk.ComboBox.NewText ();
			this.linkerCombo.Name = "linkerCombo";
			this.hbox1.Add (this.linkerCombo);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.linkerCombo]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			this.table1.Add (this.hbox1);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox1]));
			w3.TopAttach = ((uint)(1));
			w3.BottomAttach = ((uint)(2));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("_Extra arguments:");
			this.label1.UseUnderline = true;
			this.table1.Add (this.label1);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.label1]));
			w4.TopAttach = ((uint)(2));
			w4.BottomAttach = ((uint)(3));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 0F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("_Linker behavior:");
			this.label2.UseUnderline = true;
			this.table1.Add (this.label2);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2]));
			w5.TopAttach = ((uint)(1));
			w5.BottomAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.sharedRuntimeCheck = new global::Gtk.CheckButton ();
			this.sharedRuntimeCheck.CanFocus = true;
			this.sharedRuntimeCheck.Name = "sharedRuntimeCheck";
			this.sharedRuntimeCheck.Label = global::Mono.Unix.Catalog.GetString ("Use shared Mono runtime");
			this.sharedRuntimeCheck.DrawIndicator = true;
			this.sharedRuntimeCheck.UseUnderline = true;
			this.table1.Add (this.sharedRuntimeCheck);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.sharedRuntimeCheck]));
			w6.RightAttach = ((uint)(2));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			this.notebook1.Add (this.table1);
			// Notebook tab
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("General");
			this.notebook1.SetTabLabel (this.table1, this.label3);
			this.label3.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			this.vbox2.BorderWidth = ((uint)(6));
			// Container child vbox2.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 0F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Internationalization</b>");
			this.label5.UseMarkup = true;
			this.vbox2.Add (this.label5);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label5]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			this.alignment1.LeftPadding = ((uint)(24));
			// Container child alignment1.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.Xalign = 0F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("<small>If the application uses certain international codesets, they must be\nspecified explicitly so that the linker can include supporting resources.</small>");
			this.label6.UseMarkup = true;
			this.vbox3.Add (this.label6);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.label6]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.i18NTreeView = new global::Gtk.TreeView ();
			this.i18NTreeView.CanFocus = true;
			this.i18NTreeView.Name = "i18NTreeView";
			this.GtkScrolledWindow.Add (this.i18NTreeView);
			this.vbox3.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.GtkScrolledWindow]));
			w11.Position = 1;
			this.alignment1.Add (this.vbox3);
			this.vbox2.Add (this.alignment1);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.alignment1]));
			w13.Position = 1;
			this.notebook1.Add (this.vbox2);
			global::Gtk.Notebook.NotebookChild w14 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.vbox2]));
			w14.Position = 1;
			// Notebook tab
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Advanced");
			this.notebook1.SetTabLabel (this.vbox2, this.label4);
			this.label4.ShowAll ();
			this.Add (this.notebook1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.label1.MnemonicWidget = this.extraMonoDroidArgsEntry;
			this.label2.MnemonicWidget = this.linkerCombo;
			this.Hide ();
		}
	}
}
