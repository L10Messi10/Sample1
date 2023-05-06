using Firebase.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Sample1.App;

namespace Sample1.Models
{
    public class Products
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image_1_Link { get; set; }

        public async Task<string> UploadImage(Stream img, string proname, string filename)
        {
            try
            {
                var image = await _firebaseStorage
                    .Child($"Images/{proname}/{filename}")
                    .PutAsync(img);
                return image;
            }
            catch (Exception ex)
            {
                return "false";
            }
        }
        
        
        ******************************************
        var _users = new Users
                    {
                        Name = fullname,
                        Description = randomNumber,
                        Image_1_Link = _position,
                       
                    };
                    await client
                        .Child($"Users")
                        .PostAsync(_users);

        *************************************

        public async Task<bool> Save(FileResult mainimg)
        {
            var _mainimg = await UploadImage(await mainimg.OpenReadAsync(), "Studentname", $"_mainimg.png");
            
            return true;
        }
    }
}
