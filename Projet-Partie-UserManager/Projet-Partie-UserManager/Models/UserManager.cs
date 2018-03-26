using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet_Partie_UserManager.Models
{
    public class UserManager
    {

        /*
         * Méthode qui permet de créer un nouvel
         * utilisateur dans la base de donées.
         * Elle renvoie un booléen pour assurer
         * la validité de cette méthode.
         * */
        public bool CreerUser(User user)
        {
            return false;
        }


        /*
         * Méthode qui permet de modifier
         * un utilisateur. 
         * Une fois modifier nous le retournons.
         * */
        public User ModifierUser(User user)
        {
            return null;
        }


        /*
         * Méthode qui permet de supprimer
         * un utilisateur.
         * */
        public void SupprimerUser(User user)
        {

        }


        /*
         * Méthode qui permet de rechercher une Notification
         * en fonction de son ID
         * */
        public Notification RechercherNotification(int id)
        {
            return null;
        }


        /*
         * Méthode qui permet de retourner la totalité
         * des notifications de la base de données
         * */
        public List<Notification> ConsulterNotification()
        {
            return null;
        }


        /*
         * Méthode qui permet de retourner la totalité 
         * des notifications de la base de données
         * en fonction du Droit qui y a accés
         * */
        public List<Notification> ConsulterNotification(Droit droit)
        {
            return null;
        }


        /*
         * Méthode qui permet de supprimer une Notification
         * */
        public void SupprimerNotifiaction(Notification notification)
        {

        }


        /*
         * Méthode qui permet de changer l'etat de la Notification
         * */
        public Notification ChangerEtatNotifiaction(Notification notification, string etat)
        {
            return null;
        }


        /*
         * Méthode qui permet de créer une Notifiation a destination
         * des users avec un droit.
         * */
        public void CreerNotification(Droit droitDest, int typeNotif)
        {

        }
    }
}