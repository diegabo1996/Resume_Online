using LCode.Resume.Online.DataBase.Contextos.v1_0;
using NUnit.Framework;
using System;
using System.IO;

namespace LCode.Resume.Online.UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ChangePhoto()
        {
            var Photo = File.ReadAllBytes(@"D:\Soluciones\Visual Studio\Personal\LCode.Resume.Online\LCode.Resume.Online\wwwroot\img\main_photo.jpg");
            MemoryStream ms = new MemoryStream(Photo);
            Contexto contexto = new Contexto();
            Guid GIGuid = new Guid("D479B00F-8803-4704-926A-496666803E6B");
            var GeneralInformation = contexto.General_Information.Find(GIGuid);
            GeneralInformation.Photo = ms.ToArray();

            ms.Close();
            ms.Dispose();

            contexto.Update(GeneralInformation);
            contexto.SaveChanges();
        }
    }
}