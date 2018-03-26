using Projet_Partie_UserManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projet_Partie_UserManager.Controllers
{
    public class UserController : Controller
    {

        UserManager userManager = new UserManager(); 

        public bool CreerUser(User user)
        {
            return userManager.CreerUser(user);
        }

        public List<Notification> ConsulterNotification()
        {
            return userManager.ConsulterNotification();
        }

        public List<Notification> ConsulterNotification(Droit droit)
        {
            return userManager.ConsulterNotification(droit);
        }

        public void SupprimerNotifiaction(Notification notification)
        {
            userManager.SupprimerNotifiaction(notification);
        }

        public Notification ChangerEtatNotifiaction(Notification notification, string etat)
        {
            return userManager.ChangerEtatNotifiaction(notification, etat);
        }

        public void CreerNotification(Droit droitDest, int typeNotif)
        {
            userManager.CreerNotification(droitDest, typeNotif);
        }

    }
}