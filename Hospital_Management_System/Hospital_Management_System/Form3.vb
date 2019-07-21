Public Class Form3

    Private Sub AddStaffBtn_Click_1(sender As Object, e As EventArgs) Handles AddStaffBtn.Click
        PatientPanel1.BackColor = Color.Transparent
        PatientPanel2.BackColor = Color.Transparent
        BloodBankPanel1.BackColor = Color.Transparent
        BloodBankPanel2.BackColor = Color.Transparent
        PersonalInfoPanel1.BackColor = Color.Transparent
        PersonalInfoPanel2.BackColor = Color.Transparent
        StaffPanel1.Top = AddStaffBtn.Top
        StaffPanel2.Top = AddStaffBtn.Top
        StaffPanel2.BackColor = Color.DarkBlue
        StaffPanel1.BackColor = Color.DarkBlue

        AdminPanel.Controls.Clear()
        AdminPanel.Controls.Add(New AddStaff_Admin())
    End Sub

    Private Sub UpdateStaffBtn_Click(sender As Object, e As EventArgs) Handles UpdateStaffBtn.Click
        PatientPanel1.BackColor = Color.Transparent
        PatientPanel2.BackColor = Color.Transparent
        BloodBankPanel1.BackColor = Color.Transparent
        BloodBankPanel2.BackColor = Color.Transparent
        PersonalInfoPanel1.BackColor = Color.Transparent
        PersonalInfoPanel2.BackColor = Color.Transparent
        StaffPanel1.Top = UpdateStaffBtn.Top
        StaffPanel2.Top = UpdateStaffBtn.Top
        StaffPanel2.BackColor = Color.DarkBlue
        StaffPanel1.BackColor = Color.DarkBlue

        AdminPanel.Controls.Clear()
        AdminPanel.Controls.Add(New UpdateStaff_Admin())
    End Sub

    Private Sub SearchDonorBtn_Click(sender As Object, e As EventArgs) Handles SearchDonorBtn.Click
        PatientPanel1.BackColor = Color.Transparent
        PatientPanel2.BackColor = Color.Transparent
        StaffPanel1.BackColor = Color.Transparent
        StaffPanel2.BackColor = Color.Transparent
        PersonalInfoPanel1.BackColor = Color.Transparent
        PersonalInfoPanel2.BackColor = Color.Transparent
        BloodBankPanel1.Top = SearchDonorBtn.Top
        BloodBankPanel2.Top = SearchDonorBtn.Top
        BloodBankPanel1.BackColor = Color.DarkBlue
        BloodBankPanel2.BackColor = Color.DarkBlue

        AdminPanel.Controls.Clear()
        AdminPanel.Controls.Add(New SearchDonor_Admin())
    End Sub

    Private Sub SearchRecieverBtn_Click(sender As Object, e As EventArgs) Handles SearchRecieverBtn.Click
        PatientPanel1.BackColor = Color.Transparent
        PatientPanel2.BackColor = Color.Transparent
        StaffPanel1.BackColor = Color.Transparent
        StaffPanel2.BackColor = Color.Transparent
        PersonalInfoPanel1.BackColor = Color.Transparent
        PersonalInfoPanel2.BackColor = Color.Transparent
        BloodBankPanel1.Top = SearchRecieverBtn.Top
        BloodBankPanel2.Top = SearchRecieverBtn.Top
        BloodBankPanel1.BackColor = Color.DarkBlue
        BloodBankPanel2.BackColor = Color.DarkBlue

        AdminPanel.Controls.Clear()
        AdminPanel.Controls.Add(New SearchReciever_Admin())
    End Sub

    Private Sub BloodAvailabilityBtn_Click(sender As Object, e As EventArgs) Handles BloodAvailabilityBtn.Click
        PatientPanel1.BackColor = Color.Transparent
        PatientPanel2.BackColor = Color.Transparent
        StaffPanel1.BackColor = Color.Transparent
        StaffPanel2.BackColor = Color.Transparent
        PersonalInfoPanel1.BackColor = Color.Transparent
        PersonalInfoPanel2.BackColor = Color.Transparent
        BloodBankPanel1.Top = BloodAvailabilityBtn.Top
        BloodBankPanel2.Top = BloodAvailabilityBtn.Top
        BloodBankPanel1.BackColor = Color.DarkBlue
        BloodBankPanel2.BackColor = Color.DarkBlue

        AdminPanel.Controls.Clear()
        AdminPanel.Controls.Add(New BloodAvailability())
    End Sub

    Private Sub EditProfileBtn_Click(sender As Object, e As EventArgs) Handles EditProfileBtn.Click
        PatientPanel1.BackColor = Color.Transparent
        PatientPanel2.BackColor = Color.Transparent
        BloodBankPanel1.BackColor = Color.Transparent
        BloodBankPanel2.BackColor = Color.Transparent
        StaffPanel2.BackColor = Color.Transparent
        StaffPanel1.BackColor = Color.Transparent
        PersonalInfoPanel1.Top = EditProfileBtn.Top
        PersonalInfoPanel2.Top = EditProfileBtn.Top
        PersonalInfoPanel1.BackColor = Color.DarkBlue
        PersonalInfoPanel2.BackColor = Color.DarkBlue

        AdminPanel.Controls.Clear()
        AdminPanel.Controls.Add(New EditProfile())
    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        PatientPanel1.BackColor = Color.Transparent
        PatientPanel2.BackColor = Color.Transparent
        BloodBankPanel1.BackColor = Color.Transparent
        BloodBankPanel2.BackColor = Color.Transparent
        StaffPanel2.BackColor = Color.Transparent
        StaffPanel1.BackColor = Color.Transparent
        PersonalInfoPanel1.Top = LogoutBtn.Top
        PersonalInfoPanel2.Top = LogoutBtn.Top
        PersonalInfoPanel1.BackColor = Color.DarkBlue
        PersonalInfoPanel2.BackColor = Color.DarkBlue

        Form1.username = ""
        Form1.login_type = ""
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Form3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.username = ""
        Form1.login_type = ""
        Form1.Show()
    End Sub

    Private Sub SearchPtntBtn_Click(sender As Object, e As EventArgs) Handles SearchPtntBtn.Click
        BloodBankPanel1.BackColor = Color.Transparent
        BloodBankPanel2.BackColor = Color.Transparent
        StaffPanel2.BackColor = Color.Transparent
        StaffPanel1.BackColor = Color.Transparent
        PersonalInfoPanel1.BackColor = Color.Transparent
        PersonalInfoPanel2.BackColor = Color.Transparent
        PatientPanel1.Top = SearchPtntBtn.Top
        PatientPanel2.Top = SearchPtntBtn.Top
        PatientPanel1.BackColor = Color.DarkBlue
        PatientPanel2.BackColor = Color.DarkBlue

        AdminPanel.Controls.Clear()
        AdminPanel.Controls.Add(New SearchPatient_Admin())
    End Sub

    Private Sub Form3_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Refresh()
    End Sub
End Class