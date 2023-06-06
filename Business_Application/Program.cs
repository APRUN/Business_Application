using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Business_Application.bl;
using Business_Application.DL;
using Business_Application.UL;

namespace Business_Application
{
    class Program
    {
        static List<user> users = new List<user>();                          //List that contains all users and their passwords
        static List<Add_Software> softwares = new List<Add_Software>();     //List that contains all softwares
        static List<Add_Software> User_cart = new List<Add_Software>();
        static List<string> FeedbackList = new List<string>();

        static void Main(string[] args)
        {
            main_menu_control();          //Main function that controls the main menu function
        } 
        static void Mainmenu_view()
        {
            Main_Menuview.Main_view();    //UI class that view the main menu functions
        }
        static void main_menu_control()
        {
            Mainmenu_view();
            if (Main_Menuview.choice=="1")
            {
                Sign_up();               //Main function that controls the sign up functions
            }
            if(Main_Menuview.choice=="2")
            {
                Sign_in();               //Main function that controls the sign in functions
            }
        }
        static void Sign_up()
        {
            Sign_upview.view();
            users.Add(Sign_upview.add_new_user);
            write_user write = new write_user(users);
            if (Sign_upview.add_new_user.role == "admin")
                User_menu_control();
            else
                Customer_menuControl();
        }
        static void Sign_in()
        {
            Sign_inview.view();
            string is_present = check_signin(Sign_inview.user, Sign_inview.passcode);
            view_user(is_present);
        }
        static string check_signin(string name, string password)
        {
            string cnfrm="";
            foreach(var f in users)
            {
                if(name==f.username)
                {
                    cnfrm = "Present";
                }
                else
                {
                    cnfrm = "No";
                }
                if(password==f.password)
                {
                    cnfrm = "Present";
                }
                else
                {
                    cnfrm = "NO";
                }
                if(f.role=="admin")
                {
                    cnfrm = cnfrm + "admin";
                }
                else if(f.role=="user"||f.role=="USER"||f.role=="User")
                {
                    cnfrm = cnfrm + "user";
                }
            }
            return cnfrm;
        }
        static void view_user(string is_present)
        {
            if (is_present =="PresentAdmin" )
            {
                User_menu_control();                //Main functions that controls the controlling of user functions
            }
            else if(is_present=="Presentuser")
            {
                User_menu_control();
            }
            else
            {
                Console.WriteLine("Sorry! Wrong Credentials. Press '1' to Sign Up and '2' to retry.");
                Console.Write("Enter: ");
                string choice = Console.ReadLine();  //Simple taking a choice input
                if(choice=="1")
                {
                    Sign_up();
                }
                else if(choice=="2")
                {
                    Sign_in();                      
                }
            }
        }
        static void View_user_menu()
        {
            User_menuview.user_view();                   //UI to user menus
        }
        static void User_menu_control()
        {
            View_user_menu();
            if(User_menuview.choice=="0")
            {
                main_menu_control();
            }
            if (User_menuview.choice=="1")
            {
                Software_add();                                       //Calling main function to add a new software
                User_menu_control();                                 //For returning back to menu       
            }
            if(User_menuview.choice =="2")
            {
                Remove_software();                                   //Calling main function to remove a software
                User_menu_control();
            }
            if (User_menuview.choice =="3")
            {
                Update_software();                                  //Calling main function to update info of a software
                User_menu_control();
            }
            if (User_menuview.choice =="4")
            {
                View_softwares();                                   //Prints all softwares
                User_menu_control();
            }
        }
        static void Software_add()
        {
            Add_Softwareview.add_view();                                      //UI to add a software and store it in 
            Add_SoftwaretoList.Addin(softwares);                              //Adding a software to List
            Write_software_tofile write=new Write_software_tofile(softwares); //Writing software to File in txt
            Console.Write("Software Added to database.");
            Back();
        }
        static void Remove_software()
        {
            
            string name = Add_softwarename.lets_show();                  //UI to view enter a software name
            int found= Search_Software.searchnreturn(softwares, name);   //Search a software and return the index
            Delete_software(found);                                      //Calls a function and passs the index to delete the software
            Console.Write("Removed.");
            Back();
        }
        static void Delete_software(int idx)
        {
            Delete_theSoftware.Remove(idx,softwares);                   //Calls and class and send the index to remove a software at that index
        }
        static void Update_software()
        {
            string name = Add_softwarename.lets_show();                   //UI to add a softwre name and return the name
            int found = Search_Software.searchnreturn(softwares, name);  //Calling a class to search a software by name and return its index
            Primary_update(found);                      //Mainly handle the function call for changing price,size and name 
        }
        static void Update_menu()
        {
            Update_softwaremenu_view.update_view();      //UI view to update a software's info
        }
        static void Primary_update(int idx)
        {
            Console.Write("What you want to update: ");
             Update_menu();                              //Calling to view UI for updating a software info
            if (Update_softwaremenu_view.choice=="1")
            {
                Changing_name(idx);                      //Calling the change name function
            }
            if(Update_softwaremenu_view.choice =="2")
            { 
                Changing_size(idx);                     //Calling the change size function
            }
            if (Update_softwaremenu_view.choice == "3")
            {
                Changing_price(idx);                    //Calling the change price function
            }
        }

        static void Changing_name(int idx)
        {
            Change_Software.Change_name(softwares,idx);      // Change Software class has a function 1 to change name of a recent software
        }
        static void Changing_size(int idx)
        {
            Change_Software.Change_size(softwares, idx);     // Change Software class has a function 2 to change size of a recent software

        }
        static void Changing_price(int idx)
        {
            Change_Software.Change_price(softwares, idx);    // Change Software class has a function 3 to change price of a recent software
        }
        static void View_softwares()
        {
            All_softwares all = new All_softwares(softwares); //A Constructor to view all softwares
            Console.ReadKey();
            Back();
        }    
        /// ///////////////////////////     CUSTOMER    ////////////////////////////
        static void Customer_menuControl()
        {
            Customer_Mainmenu.View();
            if (Customer_Mainmenu.c_choice == "0")
            {
                main_menu_control();
            }
            if (Customer_Mainmenu.c_choice=="1")
            {
                Cart_Add();
                Customer_menuControl();
            }
            if(Customer_Mainmenu.c_choice=="2")
            {
                View_All_incart();
                Customer_menuControl();
            }
            if (Customer_Mainmenu.c_choice=="3")
            {
                View_All_incart();
                Customer_menuControl();
            }
            if (Customer_Mainmenu.c_choice=="4")
            {
                EnterFeedback();
                Customer_menuControl();
            }
        }
        static void Cart_Add()
        {
            string customer_software=Standard_Enter.view_it();
            int index= Search_Software.searchnreturn(softwares, customer_software);
            General_Softwareview.viewer(softwares[index].name, softwares[index].size, softwares[index].price);
            Add_toUsercart.add(User_cart,softwares[index]);
            Back();
        }
        static void View_All_incart()
        {
           All_softwares a=new All_softwares(User_cart);
            Back();

        }
        static void Remove_Cart()
        {
            string customer_software = Standard_Enter.view_it();
            int index = Search_Software.searchnreturn(softwares, customer_software);
            General_Softwareview.viewer(softwares[index].name, softwares[index].size, softwares[index].price);
            Delete_theSoftware.Remove(index,User_cart);
            Back();

        }
        static void EnterFeedback()
        {
            string feedback=Standard_Enter.view_it();
            Add_feedbacktoList(feedback);
            Back();
        }
        static void Add_feedbacktoList(string content)
        {
            Add_feedbackList.add(FeedbackList,content);
        }




        static void Back()
        {
            Console.Clear();
            Console.ReadKey();
        }

    }
}
