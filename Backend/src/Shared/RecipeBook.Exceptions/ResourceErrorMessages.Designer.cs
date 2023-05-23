﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RecipeBook.Exception {
    using System;
    
    
    /// <summary>
    ///   Uma classe de recurso de tipo de alta segurança, para pesquisar cadeias de caracteres localizadas etc.
    /// </summary>
    // Essa classe foi gerada automaticamente pela classe StronglyTypedResourceBuilder
    // através de uma ferramenta como ResGen ou Visual Studio.
    // Para adicionar ou remover um associado, edite o arquivo .ResX e execute ResGen novamente
    // com a opção /str, ou recrie o projeto do VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ResourceErrorMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ResourceErrorMessages() {
        }
        
        /// <summary>
        ///   Retorna a instância de ResourceManager armazenada em cache usada por essa classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RecipeBook.Exception.ResourceErrorMessages", typeof(ResourceErrorMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Substitui a propriedade CurrentUICulture do thread atual para todas as
        ///   pesquisas de recursos que usam essa classe de recurso de tipo de alta segurança.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a The user&apos;s email has already been taken..
        /// </summary>
        public static string EMAIL_EXISTS {
            get {
                return ResourceManager.GetString("EMAIL_EXISTS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a The user&apos;s email is required..
        /// </summary>
        public static string EMPTY_EMAIL {
            get {
                return ResourceManager.GetString("EMPTY_EMAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a The user&apos;s password is required..
        /// </summary>
        public static string EMPTY_PASSWORD {
            get {
                return ResourceManager.GetString("EMPTY_PASSWORD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a Thre user&apos;s phone is required..
        /// </summary>
        public static string EMPTY_PHONE {
            get {
                return ResourceManager.GetString("EMPTY_PHONE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a The user&apos;s name is required..
        /// </summary>
        public static string EMPTY_USERNAME {
            get {
                return ResourceManager.GetString("EMPTY_USERNAME", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a Current password is invalid..
        /// </summary>
        public static string INVALID_CURRENT_PASSWORD {
            get {
                return ResourceManager.GetString("INVALID_CURRENT_PASSWORD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a The user&apos;s email must be valid..
        /// </summary>
        public static string INVALID_EMAIL {
            get {
                return ResourceManager.GetString("INVALID_EMAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a Invalid Login credentials. Check the informed user&apos;s email and password again..
        /// </summary>
        public static string INVALID_LOGIN {
            get {
                return ResourceManager.GetString("INVALID_LOGIN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a The user&apos;s phone number must be valid (XX) X XXXX-XXXX..
        /// </summary>
        public static string INVALID_PHONE {
            get {
                return ResourceManager.GetString("INVALID_PHONE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a The user&apos;s password must be 6 characters..
        /// </summary>
        public static string PASSWORD_LENGTH {
            get {
                return ResourceManager.GetString("PASSWORD_LENGTH", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a Login again, please..
        /// </summary>
        public static string TOKEN_EXPIRED {
            get {
                return ResourceManager.GetString("TOKEN_EXPIRED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a Unknown Error..
        /// </summary>
        public static string UNKNOWN_ERROR {
            get {
                return ResourceManager.GetString("UNKNOWN_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a User without permission to access this resource..
        /// </summary>
        public static string WITHOUT_PERMISSION {
            get {
                return ResourceManager.GetString("WITHOUT_PERMISSION", resourceCulture);
            }
        }
    }
}
