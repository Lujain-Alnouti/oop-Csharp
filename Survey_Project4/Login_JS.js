let names = ["Lujain", "Lubna", "Malek", "Raghad", "Sohaib", "Mohammad", "Ahmad", "Sara", "Alaa", "Hala"];
let IDs = ["1324", "1224", "1424", "2724", "3324", "1624", "1524", "1124", "2324", "2424"];
function LOGIN() {
    let cond = true;
    let un = document.getElementById('<%= User_input.ClientID %>').value;
    let id = document.getElementById('<%= Id_input.ClientID %>').value;
    alert(un);
    for (let i = 0; i < names.length; i++) {
        if (un == names[i] && id == IDs[i]) {
            cond = true;
            break;
        }
        else cond = false;
    }

    if (cond == true) {
        if (localStorage.length == 0) {
            let x = localStorage.length + 1;
            localStorage.setItem(`username${x}`, un);
            localStorage.setItem(`userid${x}`, id);
        }
        else {
            for (let i = 1; i <= localStorage.length; i++) {
                if (un == localStorage.getItem(`username${x}`) && id == localStorage.getItem(`userid${x}`)) {
                    let M = document.getElementById("mess").innerHTML = "You Are Already Exist";
                    break;
            }
            else {
                    let y = localStorage.length + 1;
                localStorage.setItem(`username${y}`, UN);
                localStorage.setItem(`userID${y}`, IDU);
            }
            }

        }
    }
}
//function login_Click() {
//    let UN = document.getElementById("User_input");
//    let IDU = document.getElementById("Id_input");

//    if (localStorage.length == 0) {
//        localStorage.setItem(`username ${localStorage.length + 1}`, UN);
//        localStorage.setItem(`userID ${localStorage.length + 1}`, IDU);
//    }
//    else {
//        for (let i = 1; i <= localStorage.length; i++) {
//            if (UN == localStorage.getItem("username" + i) && IDU == localStorage.getItem("uderID" + i)) {
//                exist = true;
//                let M = document.getElementById("mess").innerHTML = "You Are Already Exist";
//            }
//            else {

//                localStorage.setItem(`username${localStorage.length + 1}`, UN);
//                localStorage.setItem(`userID${localStorage.length + 1}`, IDU);
//            }
//        }
//    }
//}