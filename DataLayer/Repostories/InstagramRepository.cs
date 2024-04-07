
using EntityLayer;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using DataLayer.Temps;
using DataLayer.Abstract;

namespace DataLayer.Repostories
{
    public class InstagramRepository: IInstagramDal
    {
        ProductRepository productRepository=new ProductRepository();
        public async void IsLogin(String _Username, String _Password)
        {

            try
            {
               
                // create user session data and provide login details
                var userSession = new UserSessionData
                {
                    UserName = _Username,
                    Password = _Password
                };


                var delay = RequestDelay.FromSeconds(2, 2);

                Staticlist.InstaApi = InstaApiBuilder.CreateBuilder()
                    .SetUser(userSession)
                    .UseLogger(new DebugLogger(LogLevel.All)) // use logger for requests and debug messages
                    .SetRequestDelay(delay)
                    .Build();

                const string stateFile = "state.bin";
                try
                {
                    if (File.Exists(stateFile))
                    {

                        using (var fs = File.OpenRead(stateFile))
                        {
                            Staticlist.InstaApi.LoadStateDataFromStream(fs);

                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                if (!Staticlist.InstaApi.IsUserAuthenticated)
                {

                    delay.Disable();
                    var logInResult = await Staticlist.InstaApi.LoginAsync(true);
                    delay.Enable();
                    if (!logInResult.Succeeded)
                    {
                        
                        Staticlist.IsLogin = false;
                    }
                    else
                    {
                        Staticlist.IsLogin = true;
                    }

                }
                else
                {
                    delay.Disable();
                    var logoutResult = await Staticlist.InstaApi.LogoutAsync();
                    delay.Enable();

                    delay.Disable();
                    var logInResult = await Staticlist.InstaApi.LoginAsync(true);
                    delay.Enable();
                    if (!logInResult.Succeeded)
                    {
                        Console.WriteLine($"Unable to login: {logInResult.Info.Message}");
                        Staticlist.IsLogin = false;
                    }
                    else
                    {
                        Staticlist.IsLogin = true;
                    }



                }
                var state = Staticlist.InstaApi.GetStateDataAsStream();
                // in .net core or uwp apps don't use GetStateDataAsStream.
                // use this one:
                // var state = _instaApi.GetStateDataAsString();
                // this returns you session as json string.
                using (var fileStream = File.Create(stateFile))
                {
                    state.Seek(0, SeekOrigin.Begin);
                    state.CopyTo(fileStream);
                }






            }
            catch (Exception ex)
            {
                Staticlist.IsLogin = false;
            }


        }
        public async void UploadPhoto(ProductModel model)
        {
            var delay = RequestDelay.FromSeconds(2, 2);
            Image img = Image.FromFile((model.Content).Replace("\\", @"\"));
            byte[] bArr = imgToByteArray(img);
            var mediaImage = new InstaImageUpload
            {

                Height = 1080,
                Width = 1080,
                ImageBytes = bArr
            };
            delay.Disable();
            var result = await Staticlist.InstaApi.MediaProcessor.UploadPhotoAsync(mediaImage, model.Title);
            delay.Enable();
            if (result.Succeeded)
            {

                model.Status = 3;
            }
            else
            {
                model.ErrorLog = result.Info.Message;
                model.Status =4;
            }
            productRepository.Update(model);
        }
        public async void UploadVieo(ProductModel model)
        {
            var delay = RequestDelay.FromSeconds(2, 2);
            var video = new InstaVideoUpload
            {
                // leave zero, if you don't know how height and width is it.
                Video = new InstaVideo(model.Content.Replace("\\", @"\"), 0, 0),
                VideoThumbnail = new InstaImage(model.Viewimage.Replace("\\", @"\"), 0, 0)
            };
            delay.Disable();
            var result = await Staticlist.InstaApi.MediaProcessor.UploadVideoAsync(video, model.Title);
            delay.Enable();
            if (result.Succeeded)
            {
     
                model.Status =3;
            }
            else
            {
                model.ErrorLog = result.Info.Message;
                model.Status =4;
            }
            productRepository.Update(model);


        }

        public async void UploadStoryPhoto(ProductModel model)
        {
            var delay = RequestDelay.FromSeconds(2, 2);
            Image img = Image.FromFile((model.Content).Replace("\\", @"\"));
            byte[] bArr = imgToByteArray(img);
            var mediaImage = new InstaImage
            {

                Height = 1080,
                Width = 1080,
                ImageBytes = bArr
            };
            delay.Disable();

            var result = await Staticlist.InstaApi.StoryProcessor.UploadStoryPhotoAsync(mediaImage, "");
            delay.Enable();
            if (result.Succeeded)
            {

                model.Status =3;
            }
            else
            {
                model.Status =4;
                model.ErrorLog = result.Info.Message;
            }
            productRepository.Update(model);
    
        }
        public async void UploadStoryVieo(ProductModel model)
        {
            var delay = RequestDelay.FromSeconds(2, 2);
            var video = new InstaVideoUpload
            {
                // leave zero, if you don't know how height and width is it.
                Video = new InstaVideo(model.Content.Replace("\\", @"\"), 0, 0),
                VideoThumbnail = new InstaImage(model.Viewimage.Replace("\\", @"\"), 0, 0)
            };
            // Add user tag (tag people)
            //video.UserTags.Add(new InstaUserTagVideoUpload
            //{
            //    Username = "rmt4006"
            //});
            delay.Disable() ;
            var result = await Staticlist.InstaApi.StoryProcessor.UploadStoryVideoAsync(video, model.Title);
            delay.Enable();
            if (result.Succeeded)
            {

                model.Status =3;
            }
            else
            {
                model.Status =4;
                model.ErrorLog = result.Info.Message;
            }
            productRepository.Update(model);
        }
        public async void IsLogout(String _Username, String _Password)
        {

            try
            {

                var userSession = new UserSessionData
                {
                    UserName = _Username,
                    Password = _Password
                };


                var delay = RequestDelay.FromSeconds(2, 2);

                Staticlist.InstaApi = InstaApiBuilder.CreateBuilder()
                    .SetUser(userSession)
                    .UseLogger(new DebugLogger(LogLevel.All)) // use logger for requests and debug messages
                    .SetRequestDelay(delay)
                    .Build();

                const string stateFile = "state.bin";
                try
                {
                    if (File.Exists(stateFile))
                    {

                        using (var fs = File.OpenRead(stateFile))
                        {
                            Staticlist.InstaApi.LoadStateDataFromStream(fs);

                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                delay.Disable();
                var logoutResult = await Staticlist.InstaApi.LogoutAsync();
                delay.Enable();

                var state = Staticlist.InstaApi.GetStateDataAsStream();
                // in .net core or uwp apps don't use GetStateDataAsStream.
                // use this one:
                // var state = _instaApi.GetStateDataAsString();
                // this returns you session as json string.
                using (var fileStream = File.Create(stateFile))
                {
                    state.Seek(0, SeekOrigin.Begin);
                    state.CopyTo(fileStream);
                }

                Staticlist.IsLogin = false;




            }
            catch (Exception ex)
            {
                Staticlist.IsLogin = false;
            }


        }

        public byte[] imgToByteArray(Image img)
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                img.Save(mStream, img.RawFormat);
                return mStream.ToArray();
            }
        }
    }
}
