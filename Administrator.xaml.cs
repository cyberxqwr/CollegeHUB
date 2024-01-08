using CollegeHUB.Back.Custom;
using CollegeHUB.Back.DBConfig;
using CollegeHUB.Back.Service;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace CollegeHUB;

public partial class Administrator : ContentPage

{
    public Administrator()
    {
        InitializeComponent();
        currentlyLoggedIn();

    }

    private void currentlyLoggedIn()
    {

        string logged = "Prisijunges kaip " + MainPage._userService.firstName + " " + MainPage._userService.lastName;
        loggedIn.Text = logged;
    }

    private async void onLogoutClicked(object sender, EventArgs e)
    {

        await Shell.Current.Navigation.PushAsync(new MainPage());
    }
    private void OnAWClicked(object sender, EventArgs e)
    {

        //Editing visibility

        RemoveWorker.IsVisible = false;
        AddInhabitant.IsVisible = false;
        RemoveInhabitant.IsVisible = false;
        CreateBuilding.IsVisible = false;
        RemoveBuilding.IsVisible = false;
        CreateRoom.IsVisible = false;
        SeeInhabitantInfo.IsVisible = false;
        AssignRoom.IsVisible = false;
        SeeWorkersInfo.IsVisible = false;
        Back.IsVisible = true;
        interfaceAddWorker.IsVisible = true;
        AddWorker.IsEnabled = false;

        groupList();

        //Debug.WriteLine("Testing userSerive visibility, username is " + MainPage._userService.Username + " password is: " + MainPage._userService.Password);

        //Alignment transform

        interfaceButtons.HorizontalOptions = LayoutOptions.Fill;
        interfaceAddWorker.HorizontalOptions = LayoutOptions.Center;

    }

    private void OnRWClicked(object sender, EventArgs e)
    {

        //Editing visibility

        AddWorker.IsVisible = false;
        AddInhabitant.IsVisible = false;
        RemoveInhabitant.IsVisible = false;
        CreateBuilding.IsVisible = false;
        RemoveBuilding.IsVisible = false;
        CreateRoom.IsVisible = false;
        SeeInhabitantInfo.IsVisible = false;
        AssignRoom.IsVisible = false;
        SeeWorkersInfo.IsVisible = false;
        Back.IsVisible = true;
        interfaceRemoveWorker.IsVisible = true;
        RemoveWorker.IsEnabled = false;

        groupList();


        //studentListPerGroup();

        //Alignment transform

        interfaceButtons.HorizontalOptions = LayoutOptions.Fill;
        interfaceRemoveWorker.HorizontalOptions = LayoutOptions.Center;

    }

    private void OnAIClicked(object sender, EventArgs e)
    {

        //Editing visibility

        RemoveWorker.IsVisible = false;
        AddWorker.IsVisible = false;
        RemoveInhabitant.IsVisible = false;
        CreateBuilding.IsVisible = false;
        RemoveBuilding.IsVisible = false;
        CreateRoom.IsVisible = false;
        SeeInhabitantInfo.IsVisible = false;
        AssignRoom.IsVisible = false;
        SeeWorkersInfo.IsVisible = false;
        Back.IsVisible = true;
        interfaceAddInhabitant.IsVisible = true;
        AddInhabitant.IsEnabled = false;

        groupList();

        //Alignment transform

        interfaceButtons.HorizontalOptions = LayoutOptions.Fill;
        interfaceAddInhabitant.HorizontalOptions = LayoutOptions.Center;

    }

    private void OnRIClicked(object sender, EventArgs e)
    {

        //Editing visibility

        RemoveWorker.IsVisible = false;
        AddInhabitant.IsVisible = false;
        AddWorker.IsVisible = false;
        CreateBuilding.IsVisible = false;
        RemoveBuilding.IsVisible = false;
        CreateRoom.IsVisible = false;
        SeeInhabitantInfo.IsVisible = false;
        AssignRoom.IsVisible = false;
        SeeWorkersInfo.IsVisible = false;
        Back.IsVisible = true;
        interfaceRemoveInhabitant.IsVisible = true;
        RemoveInhabitant.IsEnabled = false;

        lecturerList();

        //Alignment transform

        interfaceButtons.HorizontalOptions = LayoutOptions.Fill;
        interfaceRemoveInhabitant.HorizontalOptions = LayoutOptions.Center;

    }

    private void OnCBClicked(object sender, EventArgs e)
    {

        //Editing visibility

        RemoveWorker.IsVisible = false;
        AddInhabitant.IsVisible = false;
        RemoveInhabitant.IsVisible = false;
        AddWorker.IsVisible = false;
        RemoveBuilding.IsVisible = false;
        CreateRoom.IsVisible = false;
        SeeInhabitantInfo.IsVisible = false;
        AssignRoom.IsVisible = false;
        SeeWorkersInfo.IsVisible = false;
        Back.IsVisible = true;
        interfaceCreateBuilding.IsVisible = true;
        CreateBuilding.IsEnabled = false;

        groupList();

        //Alignment transform

        interfaceButtons.HorizontalOptions = LayoutOptions.Fill;
        interfaceCreateBuilding.HorizontalOptions = LayoutOptions.Center;

    }

    private void OnRBClicked(object sender, EventArgs e)
    {

        //Editing visibility

        RemoveWorker.IsVisible = false;
        AddInhabitant.IsVisible = false;
        RemoveInhabitant.IsVisible = false;
        AddWorker.IsVisible = false;
        CreateRoom.IsVisible = false;
        CreateBuilding.IsVisible = false;
        SeeInhabitantInfo.IsVisible = false;
        AssignRoom.IsVisible = false;
        SeeWorkersInfo.IsVisible = false;
        Back.IsVisible = true;
        interfaceRemoveBuilding.IsVisible = true;
        RemoveBuilding.IsEnabled = false;

        //Alignment transform

        interfaceButtons.HorizontalOptions = LayoutOptions.Fill;
        interfaceRemoveBuilding.HorizontalOptions = LayoutOptions.Center;

    }

    private void OnRGClicked(object sender, EventArgs e)
    {

        //Editing visibility

        RemoveWorker.IsVisible = false;
        AddInhabitant.IsVisible = false;
        RemoveInhabitant.IsVisible = false;
        AddWorker.IsVisible = false;
        RemoveBuilding.IsVisible = false;
        CreateBuilding.IsVisible = false;
        Back.IsVisible = true;
        SeeInhabitantInfo.IsVisible = false;
        AssignRoom.IsVisible = false;
        SeeWorkersInfo.IsVisible = false;
        interfaceCreateRoom.IsVisible = true;
        CreateRoom.IsEnabled = false;

        groupList();


        //Alignment transform

        interfaceButtons.HorizontalOptions = LayoutOptions.Fill;
        interfaceCreateRoom.HorizontalOptions = LayoutOptions.Center;

    }

    private void OnSWIClicked(object sender, EventArgs e)
    {

        //Editing visibility

        RemoveWorker.IsVisible = false;
        AddInhabitant.IsVisible = false;
        RemoveInhabitant.IsVisible = false;
        AddWorker.IsVisible = false;
        RemoveBuilding.IsVisible = false;
        CreateBuilding.IsVisible = false;
        SeeInhabitantInfo.IsVisible = false;
        AssignRoom.IsVisible = false;
        CreateRoom.IsVisible = false;
        Back.IsVisible = true;
        SeeWorkersInfo.IsEnabled = false;

        interfaceSeeWorkersInfo.IsVisible = true;

        //Alignment transform

        interfaceSeeWorkersInfo.HorizontalOptions = LayoutOptions.Center;
    }

    private void OnSIIClicked(object sender, EventArgs e)
    {

        //Editing visibility

        RemoveWorker.IsVisible = false;
        AddInhabitant.IsVisible = false;
        RemoveInhabitant.IsVisible = false;
        AddWorker.IsVisible = false;
        RemoveBuilding.IsVisible = false;
        CreateBuilding.IsVisible = false;
        SeeWorkersInfo.IsVisible = false;
        AssignRoom.IsVisible = false;
        CreateRoom.IsVisible = false;
        Back.IsVisible = true;
        SeeInhabitantInfo.IsEnabled = false;

        interfaceSeeInhabitantInfo.IsVisible = true;

        lecturesList();

        //Alignment transform

        interfaceButtons.HorizontalOptions = LayoutOptions.Fill;
        interfaceSeeInhabitantInfo.HorizontalOptions = LayoutOptions.Center;
    }

    private void OnARClicked(object sender, EventArgs e)
    {

        //Editing visibility

        RemoveWorker.IsVisible = false;
        AddInhabitant.IsVisible = false;
        RemoveInhabitant.IsVisible = false;
        AddWorker.IsVisible = false;
        RemoveBuilding.IsVisible = false;
        CreateBuilding.IsVisible = false;
        SeeWorkersInfo.IsVisible = false;
        SeeInhabitantInfo.IsVisible = false;
        CreateRoom.IsVisible = false;
        Back.IsVisible = true;
        AssignRoom.IsEnabled = false;

        interfaceAssignRoom.IsVisible = true;

        lecturesList();
        groupList();
        lecturerList();

        //Alignment transform

        interfaceButtons.HorizontalOptions = LayoutOptions.Fill;
        interfaceAssignRoom.HorizontalOptions = LayoutOptions.Center;
    }

    private void OnBackClicked(object sender, EventArgs e)
    {
        //Editing visibility

        AddWorker.IsVisible = true;
        RemoveWorker.IsVisible = true;
        AddInhabitant.IsVisible = true;
        RemoveInhabitant.IsVisible = true;
        CreateBuilding.IsVisible = true;
        RemoveBuilding.IsVisible = true;
        CreateRoom.IsVisible = true;
        SeeWorkersInfo.IsVisible = true;
        SeeInhabitantInfo.IsVisible = true;
        AssignRoom.IsVisible = true;
        Back.IsVisible = false;

        //Editing functionality

        AddWorker.IsEnabled = true;
        RemoveWorker.IsEnabled = true;
        AddInhabitant.IsEnabled = true;
        RemoveInhabitant.IsEnabled = true;
        CreateBuilding.IsEnabled = true;
        RemoveBuilding.IsEnabled = true;
        CreateRoom.IsEnabled = true;
        SeeWorkersInfo.IsEnabled = true;
        SeeInhabitantInfo.IsEnabled = true;
        AssignRoom.IsEnabled = true;


        //Interfaces visibility

        interfaceAddWorker.IsVisible = false;
        interfaceRemoveWorker.IsVisible = false;
        interfaceAddInhabitant.IsVisible = false;
        interfaceRemoveInhabitant.IsVisible = false;
        interfaceCreateBuilding.IsVisible = false;
        interfaceRemoveBuilding.IsVisible = false;
        interfaceCreateRoom.IsVisible = false;
        interfaceSeeWorkersInfo.IsVisible = false;
        interfaceSeeInhabitantInfo.IsVisible = false;
        interfaceAssignRoom.IsVisible = false;

        //Alignment transform

        interfaceButtons.HorizontalOptions = LayoutOptions.Center;

        //Reset pickers

        resetPickers();


    }

                                                                                            // BUTTONS IN INTERFACE FUNCTIONALITY \/ BEGIN

    private async void OnAddWorkerBtnClicked(object sender, EventArgs e)
    {

        var fNameEntry = FindByName("fNameEntry") as Entry;
        string fName = fNameEntry.Text;

        var lNameEntry = FindByName("lNameEntry") as Entry;
        string lName = lNameEntry.Text;

        if (lName == "" && fName == "" || fName == "" || lName == "" || lName == null && fName == null || fName == null || lName == null)
        {

            await DisplayAlert("Klaida", "Patikrinkite asmens duomenis", "Gerai");
        }
        else
        {

            bool answer = await DisplayAlert("Patvirtinimas", "Ar tikrai norite itraukti nauja studenta i sarasa?", "Taip", "Ne");

            if (answer)
            {

                CustomPickerItem selectedItem = (CustomPickerItem)AddWorkerPicker.SelectedItem;

                if (selectedItem != null)
                {

                    int id = Int32.Parse(selectedItem.Value);

                    //Debug.WriteLine("Testuojami duomenys. Studento vardas: " + fName + " studento pavarde: " + lName + " studento grupe: " + id);

                    DBConfig dB = new DBConfig();

                    string newUser = dB.generateUser(MainPage._userService.Username, MainPage._userService.Password);

                    string query = string.Format("INSERT INTO chub.users (username, password, DBuser, firstName, lastName, user_typeID) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", new object[6] { fName, lName, newUser, fName, lName, 3 });
                    dB.createQuerry(string.Format("INSERT INTO chub.student (firstName, lastName, groupID) VALUES ('{0}', '{1}', '{2}')", fName, lName, id), MainPage._userService.Username, MainPage._userService.Password);
                    dB.createQuerry(query, MainPage._userService.Username, MainPage._userService.Password);
                    dB.createQuerry(string.Format("CREATE USER '{0}' IDENTIFIED BY '{1}'", newUser, lName), MainPage._userService.Username, MainPage._userService.Password);
                    dB.createQuerry(string.Format("GRANT SELECT ON chub.grades TO '{0}'", newUser), MainPage._userService.Username, MainPage._userService.Password);
                    dB.createQuerry(string.Format("GRANT SELECT ON chub.lectures TO '{0}'", newUser), MainPage._userService.Username, MainPage._userService.Password);
                    dB.createQuerry(string.Format("GRANT SELECT ON chub.lecturer TO '{0}'", newUser), MainPage._userService.Username, MainPage._userService.Password);
                    dB.createQuerry(string.Format("GRANT SELECT ON chub.grade_type TO '{0}'", newUser), MainPage._userService.Username, MainPage._userService.Password);
                    dB.createQuerry(string.Format("GRANT SELECT ON chub.student TO '{0}'", newUser), MainPage._userService.Username, MainPage._userService.Password);
                    dB.createQuerry(string.Format("GRANT SELECT ON chub.lecturergroups TO '{0}'", newUser), MainPage._userService.Username, MainPage._userService.Password);

                    resetPickers();
                    groupList();


                    await DisplayAlert("Patvirtinimas", "Studentas itrauktas i akademine informacine sistema", "Gerai");

                }
            }
        }
    }

    private async void OnRemoveWorkerClicked(object sender, EventArgs e)
    {

        CustomPickerItem selectedItem = (CustomPickerItem)RemoveWorkerPicker2.SelectedItem;

        if (selectedItem == null) {

            await DisplayAlert("Klaida", "Nepasirinkta jokia grupe ar studentas", "Gerai");
        }
        else {

        bool answer = await DisplayAlert("Patvirtinimas", "Ar tikrai norite istrinti si studenta?", "Taip", "Ne");

        if (answer)
        {


            if (selectedItem != null)
            {

                int id = Int32.Parse(selectedItem.Value);

                DBConfig dB = new DBConfig();

                
                string fName = dB.createQuerryString(string.Format("SELECT firstName FROM chub.student WHERE studentID = '{0}'", id), MainPage._userService.Username, MainPage._userService.Password);
                string lName = dB.createQuerryString(string.Format("SELECT lastName FROM chub.student WHERE studentID = '{0}'", id), MainPage._userService.Username, MainPage._userService.Password);

                string DBuser = dB.createQuerryString(string.Format("SELECT DBuser FROM chub.users WHERE firstName = '{0}' AND lastName = '{1}'", fName, lName), MainPage._userService.Username, MainPage._userService.Password);
                dB.createQuerry(string.Format("DELETE FROM chub.student WHERE studentID = '{0}'", id), MainPage._userService.Username, MainPage._userService.Password);
                dB.createQuerry(string.Format("DELETE FROM chub.users WHERE DBuser = '{0}'", DBuser), MainPage._userService.Username, MainPage._userService.Password);
                dB.createQuerry(string.Format("DROP USER '{0}'", DBuser), MainPage._userService.Username, MainPage._userService.Password);

                resetPickers();
                groupList();

                await DisplayAlert("Patvirtinimas", "Studentas istrintas is akademines informacines sistema", "Gerai");
            }
            }
        }
    }

    private async void OnAddInhabitantBtnClicked(object sender, EventArgs e)
    {

        var fNameEntry = FindByName("fNameLEntry") as Entry;
        string fName = fNameEntry.Text;

        var lNameEntry = FindByName("lNameFEntry") as Entry;
        string lName = lNameEntry.Text;

        if (lName == "" && fName == "" || fName == "" || lName == "" || lName == null && fName == null || fName == null || lName == null)
        {

            await DisplayAlert("Klaida", "Patikrinkite asmens duomenis", "Gerai");
        }
        else
        {
            bool answer = await DisplayAlert("Patvirtinimas", "Ar tikrai norite itraukti si destytoja?", "Taip", "Ne");

            if (answer)
            {

                DBConfig dB = new DBConfig();

                string newUser = dB.generateUser(MainPage._userService.Username, MainPage._userService.Password);

                dB.createQuerry(string.Format("INSERT INTO chub.lecturer (firstName, lastName) VALUES ('{0}', '{1}')", fName, lName), MainPage._userService.Username, MainPage._userService.Password);
                dB.createQuerry(string.Format("INSERT INTO chub.users (username, password, DBuser, firstName, lastName, user_typeID) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')"
                    , new object[6] { fName, lName, newUser, fName, lName, 2 }), MainPage._userService.Username, MainPage._userService.Password);
                dB.createQuerry(string.Format("CREATE USER '{0}' IDENTIFIED BY '{1}'", newUser, lName), MainPage._userService.Username, MainPage._userService.Password);
                dB.createQuerry(string.Format("GRANT SELECT, UPDATE, INSERT ON chub.grades TO '{0}'", newUser), MainPage._userService.Username, MainPage._userService.Password);
                dB.createQuerry(string.Format("GRANT SELECT ON chub.lectures TO '{0}'", newUser), MainPage._userService.Username, MainPage._userService.Password);
                dB.createQuerry(string.Format("GRANT SELECT ON chub.student TO '{0}'", newUser), MainPage._userService.Username, MainPage._userService.Password);
                dB.createQuerry(string.Format("GRANT SELECT ON chub.lecturer TO '{0}'", newUser), MainPage._userService.Username, MainPage._userService.Password);
                dB.createQuerry(string.Format("GRANT SELECT ON chub.groups TO '{0}'", newUser), MainPage._userService.Username, MainPage._userService.Password);
                dB.createQuerry(string.Format("GRANT SELECT ON chub.lecturergroups TO '{0}'", newUser), MainPage._userService.Username, MainPage._userService.Password);
                dB.createQuerry(string.Format("GRANT SELECT ON chub.grade_type TO '{0}'", newUser), MainPage._userService.Username, MainPage._userService.Password);

                resetPickers();
                groupList();

                await DisplayAlert("Patvirtinimas", "Destytojas itrauktas i akademine informacine sistema", "Gerai");
            }
        }


    }

    private async void OnRemoveInhabitantBtnClicked(object sender, EventArgs e)
    {

        CustomPickerItem selectedItem = (CustomPickerItem)RemoveInhabitantPicker.SelectedItem;

        if (selectedItem != null)
        {
            bool answer = await DisplayAlert("Patvirtinimas", "Ar tikrai norite istrinti si destytoja?", "Taip", "Ne");

            if (answer)
            {


                int id = Int32.Parse(selectedItem.Value);

                DBConfig dB = new DBConfig();
                
                string fName = dB.createQuerryString(string.Format("SELECT firstName FROM chub.lecturer WHERE lecturerID = '{0}'", id), MainPage._userService.Username, MainPage._userService.Password);
                string lName = dB.createQuerryString(string.Format("SELECT lastName FROM chub.lecturer WHERE lecturerID = '{0}'", id), MainPage._userService.Username, MainPage._userService.Password);
                string DBuser = dB.createQuerryString(string.Format("SELECT DBuser FROM chub.users WHERE firstName = '{0}' AND lastName = '{1}'", fName, lName), MainPage._userService.Username, MainPage._userService.Password);
                dB.createQuerry(string.Format("DELETE FROM chub.lecturer WHERE lecturerID = '{0}'", id), MainPage._userService.Username, MainPage._userService.Password);
                dB.createQuerry(string.Format("DELETE FROM chub.users WHERE firstName = '{0}' AND lastName = '{1}'", fName, lName), MainPage._userService.Username, MainPage._userService.Password);
                dB.createQuerry(string.Format("DROP USER '{0}'", DBuser), MainPage._userService.Username, MainPage._userService.Password);

                resetPickers();
                lecturerList();

                await DisplayAlert("Patvirtinimas", "Destytojas istrintas is akademines informacines sistema", "Gerai");
            }

        }
        else await DisplayAlert("Klaida", "Nepasirinktas joks destytojas", "Gerai");

    }

    private async void OnCreateBuildingBtnClicked(object sender, EventArgs e)
    {

        int resultInt;
        string result;

        CustomPickerItem selectedItem = (CustomPickerItem)CreateBuildingPicker3.SelectedItem;

        if (selectedItem != null)
        {

            bool answer = await DisplayAlert("Patvirtinimas", "Ar tikrai norite redaguoti sio studento pazymi?", "Taip", "Ne");

            int id = Int32.Parse(selectedItem.Value);
            DBConfig dB = new DBConfig();

            if (answer)
            {

                do
                {

                    result = await DisplayPromptAsync("Pazymio keitimas", "Iveskite nauja pazymi", accept: "Patvirtinti", cancel: "Atsaukti");
                    bool checkIfInt = int.TryParse(result, out resultInt);

                    if (resultInt > 0 && resultInt <= 10 && checkIfInt)
                    {

                        dB.createQuerry(string.Format("UPDATE chub.grades SET grade = '{0}' WHERE gradeID = '{1}'", resultInt, id), MainPage._userService.Username, MainPage._userService.Password);

                        await DisplayAlert("Patvirtinimas", "Pazymys atnaujintas", "Gerai");
                    }
                    else

                    {
                        await DisplayAlert("Pranesimas", "Skaicius neivestas, arba neegzistuoja normoje nuo 1 iki 10", "Gerai");
                    }
                } while (resultInt <= 0 && resultInt > 10);

                resetPickers();
                groupList();
            }
        }   else await DisplayAlert("Klaida", "Nepasirinkta grupe, studentas, ar pazymys", "Gerai");

    }

    private async void OnRemoveBuildingBtnClicked(object sender, EventArgs e)
    {

        DBConfig dB = new DBConfig();

        var fNameEntry = FindByName("gNameEntry") as Entry;
        string fName = fNameEntry.Text;
        string checkName = dB.createQuerryString(string.Format("SELECT groupName FROM chub.groups WHERE groupName = '{0}'", fName), MainPage._userService.Username, MainPage._userService.Password);


        if (fName == "" || fName == null)
        {
            await DisplayAlert("Klaida", "Patikrinkite grupes pavadinima", "Gerai");
            } else if (fName == checkName){

            await DisplayAlert("Klaida", "Tokia grupe jau egzistuoja", "Gerai");
            }
        else
        {
            bool answer = await DisplayAlert("Patvirtinimas", "Ar tikrai norite itraukti sia grupe?", "Taip", "Ne");

            if (answer)
            {

                string query = string.Format("INSERT INTO chub.groups (groupName) VALUES ('{0}')", fName);
                dB.createQuerry(query, MainPage._userService.Username, MainPage._userService.Password);

                await DisplayAlert("Patvirtinimas", "Grupe itraukta i informacine sistema", "Gerai");

            }
        }

    }

    private async void OnCreateRoomBtnClicked(object sender, EventArgs e)
    {

        DBConfig dB = new DBConfig();
        CustomPickerItem selectedItem = (CustomPickerItem)createRoomPicker.SelectedItem;

        if (selectedItem != null)
        {

            int id = Int32.Parse(selectedItem.Value);

            string queryCheckForStudents = string.Format("SELECT COUNT(*) FROM chub.student WHERE groupID = '{0}'", id);

            if (dB.checkIfRelative(queryCheckForStudents, MainPage._userService.Username, MainPage._userService.Password))
            {
                await DisplayAlert("Klaida", "Sioje grupeje egzistuoja studentu, todel grupes trynimas negalimas", "Gerai");

            } 
            else
            {

                bool answer = await DisplayAlert("Patvirtinimas", "Ar tikrai norite istrinti sia grupe?", "Taip", "Ne");

                if (answer)
                {

                    dB.createQuerry(string.Format("DELETE FROM chub.groups WHERE groupID = '{0}'", id), MainPage._userService.Username, MainPage._userService.Password);

                    resetPickers();
                    groupList();

                    await DisplayAlert("Patvirtinimas", "Grupe istrinta is informacines sistemos", "Gerai");

                }
            }
        }
        else await DisplayAlert("Klaida", "Nepasirinkta jokia grupe", "Gerai");

    }

    private async void OnSeeWorkersInfoBtnClicked(object sender, EventArgs e)
    {

        var lNameEntry = FindByName("lectureNameEntry") as Entry;
        string lName = lNameEntry.Text;

        DBConfig dB = new DBConfig();
        bool checkName = dB.checkIfRelative(string.Format("SELECT COUNT(*) FROM chub.lectures WHERE lectureName = '{0}'", lName), MainPage._userService.Username, MainPage._userService.Password);
        
        if (lName == null || lName == "") {

            await DisplayAlert("Klaida", "Neivestas paskaitos pavadinimas", "Gerai");
        }

        else if (checkName)
        {

            await DisplayAlert("Klaida", "Tokia paskaita jau egzistuoja", "Gerai");
        }
        else {

            bool answer = await DisplayAlert("Patvirtinimas", "Ar tikrai norite sukurti sia paskaita?", "Taip", "Ne");

            if (answer)
            {

                dB.createQuerry(string.Format("INSERT INTO chub.lectures (lectureName) VALUES ('{0}')", lName), MainPage._userService.Username, MainPage._userService.Password);

                await DisplayAlert("Patvirtinimas", "Paskaita sukurta", "Gerai");
            }
        }
    }

    private async void OnSeeInhabitantInfoBtnClicked(object sender, EventArgs e)
    {

        CustomPickerItem pickedItem = (CustomPickerItem)lectureRemovePicker.SelectedItem;


        if (pickedItem != null)
        {
            bool answer = await DisplayAlert("Patvirtinimas", "Ar tikrai norite istrinti sia paskaita? Istrindami ja, istrinsite ir visiems studentams, priskirtiems jai", "Taip", "Ne");

            if (answer)
            {

                int id = Int32.Parse(pickedItem.Value);

                DBConfig dB = new DBConfig();
                dB.createQuerry(string.Format("DELETE FROM chub.lectures WHERE lectureID = '{0}'", id), MainPage._userService.Username, MainPage._userService.Password);
                dB.createQuerry(string.Format("DELETE FROM chub.lecturergroups WHERE lectureID = '{0}'", id), MainPage._userService.Username, MainPage._userService.Password);

                await DisplayAlert("Patvirtinimas", "Paskaita istrinta", "Gerai");

                resetPickers();
                lecturesList();
            }
        }
        else await DisplayAlert("Klaida", "Nepasirinkta jokia paskaita", "Gerai");
    }

    private async void OnAssignRoomBtnClicked(object sender, EventArgs e)
    {

        CustomPickerItem selectedLecture = (CustomPickerItem)AssignRoomPicker1.SelectedItem;
        CustomPickerItem selectedGroup = (CustomPickerItem)AssignRoomPicker2.SelectedItem;
        CustomPickerItem selectedLecturer = (CustomPickerItem)AssignRoomPicker3.SelectedItem;

        if (selectedLecture != null && selectedGroup != null && selectedLecturer != null)
        {

            int lectureID = Int32.Parse(selectedLecture.Value);
            int groupID = Int32.Parse(selectedGroup.Value);
            int lecturerID = Int32.Parse(selectedLecturer.Value);
            DBConfig dB = new DBConfig();

            bool checkForRepeating = dB.checkIfRelative(string.Format("SELECT COUNT(*) FROM chub.lecturergroups WHERE lectureID = '{0}' AND lecturerID = '{1}' AND groupID = '{2}'", lectureID, lecturerID, groupID), 
                MainPage._userService.Username, MainPage._userService.Password);

            if (!checkForRepeating)
            {

                bool answer = await DisplayAlert("Patvirtinimas", "Ar tikrai norite sia paskaita priskirti pasirinktai grupei bei destytojui?", "Taip", "Ne");

                if (answer)
                {


                    dB.createQuerry(string.Format("INSERT INTO chub.lecturergroups (lectureID, lecturerID, groupID) VALUES ('{0}', '{1}', '{2}')", lectureID, lecturerID, groupID), MainPage._userService.Username, MainPage._userService.Password);

                    await DisplayAlert("Patvirtinimas", "Paskaita priskirta grupei bei destytojui", "Gerai");
                }
            } else if (checkForRepeating)
            {

                await DisplayAlert("Klaida", "Destytojas jau paskirtas siai paskaitai siai grupei", "Gerai");
            }
        }
        else await DisplayAlert("Klaida", "Kazkuris laukas yra tuscias, perziurekite parametrus", "Gerai");
    }

                                                                            // BUTTONS IN INTERFACE FUNCTIONALITY /\ END

                                                                            // FUNCTIONALITY, DROP-DOWN LISTS, DATATABLE CONVERSIONS \/ BEGIN

    private void resetPickers()
    {
        createRoomPicker.ItemsSource = null;
        RemoveInhabitantPicker.ItemsSource = null;
        RemoveWorkerPicker2.ItemsSource = null;
        CreateBuildingPicker1.ItemsSource = null;
        CreateBuildingPicker2.ItemsSource = null;
        CreateBuildingPicker3.ItemsSource = null;
        AddWorkerPicker.ItemsSource = null;
        RemoveWorkerPicker1.ItemsSource = null;

    }

    private async void groupList()
    {
        string query = "SELECT groupID, groupName FROM chub.groups";
        DBConfig dB = new DBConfig();
        var groupListUnusable = await dB.getData(query, MainPage._userService.Username, MainPage._userService.Password);
        DataTable dT = dB.transformToDT(groupListUnusable, new List<string> { "groupID", "groupName" });


        List<CustomPickerItem> pickerItems = new List<CustomPickerItem>();

        foreach (DataRow row in dT.Rows)

        {
            string value = row["groupID"].ToString();
            string displayText = row["groupName"].ToString();


            pickerItems.Add(new CustomPickerItem(displayText, value));
        };

        AddWorkerPicker.ItemsSource = pickerItems;
        RemoveWorkerPicker1.ItemsSource = pickerItems;
        CreateBuildingPicker1.ItemsSource = pickerItems;
        createRoomPicker.ItemsSource = pickerItems;
        AssignRoomPicker2.ItemsSource = pickerItems;
    }

    private async void lecturesList()
    {
        string query = "SELECT lectureID, lectureName FROM chub.lectures";
        DBConfig dB = new DBConfig();
        var lectureListUnusable = await dB.getData(query, MainPage._userService.Username, MainPage._userService.Password);
        DataTable dT = dB.transformToDT(lectureListUnusable, new List<string> { "lectureID", "lectureName" });


        List<CustomPickerItem> pickerItems = new List<CustomPickerItem>();

        foreach (DataRow row in dT.Rows)

        {
            string value = row["lectureID"].ToString();
            string displayText = row["lectureName"].ToString();


            pickerItems.Add(new CustomPickerItem(displayText, value));
        };

        lectureRemovePicker.ItemsSource = pickerItems;
        AssignRoomPicker1.ItemsSource = pickerItems;
    }

    private async void lecturerList()
    {
        string query = "SELECT lecturerID, firstName, lastName FROM chub.lecturer";
        DBConfig dB = new DBConfig();
        var groupListUnusable = await dB.getData(query, MainPage._userService.Username, MainPage._userService.Password);
        DataTable dT = dB.transformToDT(groupListUnusable, new List<string> { "lecturerID", "firstName", "lastName" });


        List<CustomPickerItem> pickerItems = new List<CustomPickerItem>();

        foreach (DataRow row in dT.Rows)

        {
            string value = row["lecturerID"].ToString();
            string displayText1 = row["firstName"].ToString();
            string displayText2 = row["lastName"].ToString();
            string displayText = displayText1 + " " + displayText2;


            pickerItems.Add(new CustomPickerItem(displayText, value));
        };

        RemoveInhabitantPicker.ItemsSource = pickerItems;
        AssignRoomPicker3.ItemsSource = pickerItems;
    }

    //private async void studentListPerGroup()
    //{

    //    CustomPickerItem selectedItem = (CustomPickerItem)RemoveWorkerPicker1.SelectedItem;

    //    int groupID = Int32.Parse(selectedItem.Value);

    //    string query = string.Format("SELECT studentID, firstName, lastName WHERE groupID = '{0}'", groupID);
    //    DBConfig dB = new DBConfig();
    //    var studentListUnusable = await dB.getData(query, MainPage._userService.Username, MainPage._userService.Password);
    //    DataTable dT = dB.transformToDT(studentListUnusable, new List<string> { "studentID", "firstName", "lastName" });

    //    List<CustomPickerItem> pickerItems = new List<CustomPickerItem>();

    //    foreach ( DataRow row in dT.Rows)
    //    {

    //        string value = row["studentID"].ToString();
    //        string displayText = row["firstName" + "lastName"].ToString();

    //        pickerItems.Add(new CustomPickerItem(displayText, value));
    //    }; 

    //    RemoveWorkerPicker2.ItemsSource = pickerItems;


    //}

    private async void OnPicker1IndexChange(object sender, EventArgs e)
    {

        CustomPickerItem selectedItem = (CustomPickerItem)RemoveWorkerPicker1.SelectedItem;

        if (selectedItem != null)
        {

            int groupID = Int32.Parse(selectedItem.Value);

            string query = string.Format("SELECT studentID, firstName, lastName FROM chub.student WHERE groupID = '{0}'", groupID);
            DBConfig dB = new DBConfig();
            var studentListUnusable = await dB.getData(query, MainPage._userService.Username, MainPage._userService.Password);
            DataTable dT = dB.transformToDT(studentListUnusable, new List<string> { "studentID", "firstName", "lastName" });

            List<CustomPickerItem> pickerItems = new List<CustomPickerItem>();

            foreach (DataRow row in dT.Rows)
            {

                string value = row["studentID"].ToString();
                string displayText1 = row["firstName"].ToString();
                string displayText2 = row["lastName"].ToString();
                string displayText = displayText1 + " " + displayText2;

                pickerItems.Add(new CustomPickerItem(displayText, value));
            };

            RemoveWorkerPicker2.ItemsSource = pickerItems;

        }

    }

    private async void OnEGPicker1Index(object sender, EventArgs e)
    {
        CustomPickerItem selectedItem = (CustomPickerItem)CreateBuildingPicker1.SelectedItem;

        if (selectedItem != null)
        {

            int groupID = Int32.Parse(selectedItem.Value);

            string query = string.Format("SELECT studentID, firstName, lastName FROM chub.student WHERE groupID = '{0}'", groupID);

            DBConfig dB = new DBConfig();
            var studentListUnusable = await dB.getData(query, MainPage._userService.Username, MainPage._userService.Password);
            DataTable dT = dB.transformToDT(studentListUnusable, new List<string> { "studentID", "firstName", "lastName" });

            List<CustomPickerItem> pickerItems = new List<CustomPickerItem>();

            foreach (DataRow row in dT.Rows)
            {

                string value = row["studentID"].ToString();
                string displayText1 = row["firstName"].ToString();
                string displayText2 = row["lastName"].ToString();
                string displayText = displayText1 + " " + displayText2;

                pickerItems.Add(new CustomPickerItem(displayText, value));
            };

            CreateBuildingPicker2.ItemsSource = pickerItems;
        }
    }

    private async void OnEGPicker2Index(object sender, EventArgs e)
    {
        CustomPickerItem selectedItem = (CustomPickerItem)CreateBuildingPicker2.SelectedItem;

        if (selectedItem != null)
        {

            int studentID = Int32.Parse(selectedItem.Value);

            string query = string.Format("SELECT gradeID, grade, grade_typeID, lectureID FROM chub.grades WHERE studentID = '{0}'", studentID);
            DBConfig dB = new DBConfig();
            var gradeListUnusable = await dB.getData(query, MainPage._userService.Username, MainPage._userService.Password);

            DataTable dT = dB.transformToDT(gradeListUnusable, new List<string> { "gradeID", "grade", "grade_typeID", "lectureID" });

            List<CustomPickerItem> pickerItems = new List<CustomPickerItem>();

            foreach (DataRow row in dT.Rows)
            {

                string value = row["gradeID"].ToString();
                string displayText1 = row["grade"].ToString();
                string displayText2 = row["grade_typeID"].ToString();
                string lectureName = dB.createQuerryString(string.Format("SELECT lectureName FROM chub.lectures WHERE lectureID = '{0}'", Int32.Parse(row["lectureID"].ToString())), 
                    MainPage._userService.Username, MainPage._userService.Password);

                int gradeID = Int32.Parse(displayText2);
                displayText2 = dB.getGradeTypeString(gradeID, MainPage._userService.Username, MainPage._userService.Password);
                string displayText = lectureName + " - " + displayText2 + " " + displayText1;

                pickerItems.Add(new CustomPickerItem(displayText, value));
            };

            CreateBuildingPicker3.ItemsSource = pickerItems;
        }
    }



}