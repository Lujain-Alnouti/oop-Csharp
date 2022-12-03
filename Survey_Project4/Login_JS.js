let names = ["Lujain", "Lubna", "Malek", "Raghad", "Sohaib", "Mohammad", "Ahmad", "Sara", "Alaa", "Hala"];
let IDs = ["1324", "1224", "1424", "2724", "3324", "1624", "1524", "1124", "2324", "2424"];
let user_object = {
    username:"",
    userid:"",
    }
function LOGIN() {
    let cond = true;
    let un = document.getElementById('<%= User_input.ClientID %>').value;
    let id = document.getElementById('<%= Id_input.ClientID %>').value;
    for (let i = 0; i < names.length; i++) {
        if (un == names[i] && id == IDs[i]) {
            cond = true;
            break;
        }
        else cond = false;
    }

    if (cond == true) {
        if (localStorage.length == 0) {
            user_object.username = un;
            user_object.userid = id;
            localStorage.setItem(`${localStorage.length + 1}`, JSON.stringify(user_object));
        }
        else {
            for (let i = 1; i <= localStorage.length; i++) {
                if (un == JSON.parse(localStorage.getItem(i)).username && id == JSON.parse(localStorage.getItem(i)).userid) {
                    document.getElementById("mess").innerHTML = "You Are Already Exist";
                    break;
            }
            else {
                    user_object.username = un;
                    user_object.userid = id;
                    localStorage.setItem(`${localStorage.length + 1}`, JSON.stringify(user_object));
            }
            }
        }
    }
    else { document.getElementById("mess").innerHTML = "This Name Not Exist !"; }
}
