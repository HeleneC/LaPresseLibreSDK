﻿/**
* @author  Bastien Caubet <bastien@nextinpact.com>, Luc Raymond <luc@nextinpact.com>
* 
* The MIT License (MIT) Copyright (c) 2016 INpact Mediagroup
*
* Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
*
* The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
*
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/
namespace sdk_lpl_mvc5.Models
{
    /// <summary>
    /// Modèle de réponse
    /// Représente le modèle de données envoyé en réponse d'une requête de création ou de mise à jour de compte partenaire
    /// </summary>
    public class ValidationResponseModel
    {
        public bool IsValid { get; set; }
        public string CodeUtilisateur { get; set; }
        public int PartenaireID { get; set; }
        public int CodeEtat { get; set; }

        public void CreateDummyModel()
        {
            CodeUtilisateur = "dummy";
            IsValid = true;
            CodeEtat = Etat.Success;
        }
    }

    public enum Etat
    {
        Success = 1,
        EmailExist = 2,
        UsernameExist = 3,
        Fail = 4
    };
}
