Imports System.Windows
Imports System.Collections.ObjectModel
Imports DevExpress.Xpf.Grid
Imports System.Collections.Generic

Namespace How_to_Specify_Nodes_Filter_Mode
	Partial Public Class MainWindow
		Inherits Window

		Public Class Employee
			Public Property ID() As Integer
			Public Property ParentID() As Integer
			Public Property Name() As String
			Public Property Position() As String
			Public Property Department() As String
			Public Property OnVacation() As Boolean
			Public Property Enabled() As Boolean
			Public Overrides Function ToString() As String
				Return Name
			End Function
		End Class

		Public NotInheritable Class Stuff

			Private Sub New()
			End Sub

			Public Shared Function GetStuff() As ObservableCollection(Of Employee)
'INSTANT VB NOTE: The variable stuff was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
				Dim stuff_Renamed As New ObservableCollection(Of Employee)()
				stuff_Renamed.Add(New Employee() With {
					.ID = 1,
					.ParentID = 0,
					.Name = "Gregory S. Price",
					.Department = "",
					.Position = "President",
					.OnVacation = False,
					.Enabled = False
				})
				stuff_Renamed.Add(New Employee() With {
					.ID = 5,
					.ParentID = 1,
					.Name = "Karen J. Kelly",
					.Department = "Finance",
					.Position = "Vice President",
					.OnVacation = False,
					.Enabled = True
				})
				stuff_Renamed.Add(New Employee() With {
					.ID = 2,
					.ParentID = 1,
					.Name = "Irma R. Marshall",
					.Department = "Marketing",
					.Position = "Vice President",
					.OnVacation = False,
					.Enabled = False
				})
				stuff_Renamed.Add(New Employee() With {
					.ID = 3,
					.ParentID = 1,
					.Name = "John C. Powell",
					.Department = "Operations",
					.Position = "Vice President",
					.OnVacation = False,
					.Enabled = False
				})

				stuff_Renamed.Add(New Employee() With {
					.ID = 6,
					.ParentID = 2,
					.Name = "Brian C. Cowling",
					.Department = "Marketing",
					.Position = "Manager",
					.OnVacation = False,
					.Enabled = False
				})
				stuff_Renamed.Add(New Employee() With {
					.ID = 7,
					.ParentID = 2,
					.Name = "Thomas C. Dawson",
					.Department = "Marketing",
					.Position = "Manager",
					.OnVacation = True,
					.Enabled = False
				})
				stuff_Renamed.Add(New Employee() With {
					.ID = 8,
					.ParentID = 2,
					.Name = "Angel M. Wilson",
					.Department = "Marketing",
					.Position = "Manager",
					.OnVacation = False,
					.Enabled = True
				})
				stuff_Renamed.Add(New Employee() With {
					.ID = 9,
					.ParentID = 2,
					.Name = "Bryan R. Henderson",
					.Department = "Marketing",
					.Position = "Manager",
					.OnVacation = False,
					.Enabled = True
				})

				stuff_Renamed.Add(New Employee() With {
					.ID = 10,
					.ParentID = 3,
					.Name = "Harold S. Brandes",
					.Department = "Operations",
					.Position = "Manager",
					.OnVacation = True,
					.Enabled = True
				})
				stuff_Renamed.Add(New Employee() With {
					.ID = 11,
					.ParentID = 3,
					.Name = "Michael S. Blevins",
					.Department = "Operations",
					.Position = "Manager",
					.OnVacation = False,
					.Enabled = True
				})
				stuff_Renamed.Add(New Employee() With {
					.ID = 12,
					.ParentID = 3,
					.Name = "Jan K. Sisk",
					.Department = "Operations",
					.Position = "Manager",
					.OnVacation = False,
					.Enabled = True
				})
				stuff_Renamed.Add(New Employee() With {
					.ID = 13,
					.ParentID = 3,
					.Name = "Sidney L. Holder",
					.Department = "Operations",
					.Position = "Manager",
					.OnVacation = False,
					.Enabled = True
				})

				stuff_Renamed.Add(New Employee() With {
					.ID = 14,
					.ParentID = 1,
					.Name = "James L. Kelsey",
					.Department = "Production",
					.Position = "Manager",
					.OnVacation = False,
					.Enabled = False
				})
				stuff_Renamed.Add(New Employee() With {
					.ID = 15,
					.ParentID = 1,
					.Name = "Howard M. Carpenter",
					.Department = "Production",
					.Position = "Manager",
					.OnVacation = False,
					.Enabled = True
				})
				stuff_Renamed.Add(New Employee() With {
					.ID = 16,
					.ParentID = 1,
					.Name = "Jennifer T. Tapia",
					.Department = "Production",
					.Position = "Manager",
					.OnVacation = False,
					.Enabled = True
				})

				Return stuff_Renamed
			End Function
		End Class
		Public Sub New()
			InitializeComponent()
			gridControl.ItemsSource = Stuff.GetStuff()

			Dim filterModes As New List(Of TreeListFilterMode)()
			filterModes.Add(TreeListFilterMode.Smart)
			filterModes.Add(TreeListFilterMode.Standard)
			filterModes.Add(TreeListFilterMode.Extended)
			filterModes.Add(TreeListFilterMode.ExtendedWithChildren)
			listBoxEdit.ItemsSource = filterModes
		End Sub
	End Class
End Namespace