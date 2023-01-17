﻿using KMap230106.Data;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KMap230106.HttpServer
{
    public class Sub_Httpwebrequest
    {
       
        //  http://localhost:4000/borimap
        static readonly HttpClient client = new HttpClient();
        private List<SubData> datas = new List<SubData>();
        private string M_url = "http://localhost:4000/";
        private string url_get = "admin/getsubform";
        private string url_create = "admin/postsubformcreate";
        private string url_update = "admin/postsubformupdate";
        private string url_delete = "admin/postsubformdelete";


        public async Task<string> CreateMarkerPost(string title, string description, string img, string imgurl)
        {
            #region 송신 설정 Post Get 등등
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(M_url + url_create);
            request.Method = "POST";
            request.ContentType = "application/json; charset=utf-8";
            request.Timeout = 10 * 1000; // 응답 최대 10초
            #endregion

            #region Data를 쓰는 데 사용할 Stream 개체 설정 (Post나 Patch, Update등 보디에 들어갈 정보 )
            await using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                /*     string json = "{\"text\":\"" + str + "\"}";*/
                //json 보내기위해서 설정하는과정
                string json =
                    "{\"title\":\"" + title + "\"," +
                    "\"description\":\"" + description + "\"," +
                    "\"img\":\"" + img + "\"," +
                    "\"imgurl\":\"" + imgurl + "\"}";//double

                // 보낼 데이터를 byteArray로 바꿔준다.

                // 요청 Data를 쓰는 데 사용할 Stream 개체를 가져온다.
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();

                /*     var httpResponse = (HttpWebResponse)request.GetResponse();*/


            }
            #endregion

            #region Data 요청된 데이터 받아오는
            using (HttpWebResponse resp = (HttpWebResponse)request.GetResponse())
            {
                HttpStatusCode status = resp.StatusCode;
                Console.WriteLine(status);      // status 가 정상일경우 OK가 입력된다.

                // 응답과 관련된 stream을 가져온다.
                Stream respStream = resp.GetResponseStream();
                using (StreamReader streamReader = new StreamReader(respStream))
                {
                    string responseText = streamReader.ReadToEnd();
                    return responseText;
                }
            }
            #endregion

        }

        public async Task<string> DeleteMarkerPost(int id)
        {

            #region 송신 설정 Post Get 등등

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(M_url + url_delete);
            request.Method = "POST";
            request.ContentType = "application/json; charset=utf-8";
            request.Timeout = 10 * 1000; // 응답 최대 10초
            #endregion

            #region Data를 쓰는 데 사용할 Stream 개체 설정 (Post나 Patch, Update등 보디에 들어갈 정보 )
            await using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                /*     string json = "{\"text\":\"" + str + "\"}";*/
                //json 보내기위해서 설정하는과정
                string json =
                    "{\"id\":" + id + "}";

                // 보낼 데이터를 byteArray로 바꿔준다.

                // 요청 Data를 쓰는 데 사용할 Stream 개체를 가져온다.
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();

            }
            #endregion

            #region Data 요청된 데이터 받아오는
            using (HttpWebResponse resp = (HttpWebResponse)request.GetResponse())
            {
                HttpStatusCode status = resp.StatusCode;
                Console.WriteLine(status);      // status 가 정상일경우 OK가 입력된다.

                // 응답과 관련된 stream을 가져온다.
                Stream respStream = resp.GetResponseStream();
                using (StreamReader streamReader = new StreamReader(respStream))
                {
                    string responseText = streamReader.ReadToEnd();
                    return responseText;
                }
            }
            #endregion

        }

        public async Task<string> UpdateDataPost(int id,string title, string description, string img, string imgurl)
        {
            #region 송신 설정 Post Get 등등
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(M_url + url_update);
            request.Method = "POST";
            request.ContentType = "application/json; charset=utf-8";
            request.Timeout = 10 * 1000; // 응답 최대 10초
            #endregion

            #region Data를 쓰는 데 사용할 Stream 개체 설정 (Post나 Patch, Update등 보디에 들어갈 정보 )
            await using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                /*     string json = "{\"text\":\"" + str + "\"}";*/
                //json 보내기위해서 설정하는과정
                string json =
                   "{\"id\":" + id + "," +
                   "\"title\":\"" + title + "\"," +
                   "\"description\":\"" + description + "\"," +
                   "\"img\":\"" + img + "\"," +
                   "\"description\":\"" + description + "\"," +
                   "\"imgurl\":\"" + imgurl + "\"}";//double
                // 보낼 데이터를 byteArray로 바꿔준다.

                // 요청 Data를 쓰는 데 사용할 Stream 개체를 가져온다.
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
                #endregion
                #region Data 요청된 데이터 받아오는
                using (HttpWebResponse resp = (HttpWebResponse)request.GetResponse())
                {
                    HttpStatusCode status = resp.StatusCode;
                    Console.WriteLine(status);      // status 가 정상일경우 OK가 입력된다.

                    // 응답과 관련된 stream을 가져온다.
                    Stream respStream = resp.GetResponseStream();
                    using (StreamReader streamReader = new StreamReader(respStream))
                    {
                        string responseText = streamReader.ReadToEnd();
                        return responseText;
                    }
                }
                #endregion
            }
        }

        public async Task<List<SubData>> RecData()
        {
            /*      try
                  {*/

            HttpResponseMessage response = await client.GetAsync(M_url + url_get);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            // Above three lines can be replaced with new helper method below
            // string responseBody = await client.GetStringAsync(uri);
            response.Dispose();


            return JsonParser(responseBody);
            /*           }
                       catch (HttpRequestException e)
                       {
                           MessageBox.Show("에러발생\n" + e);
                       }
                       return JsonParser("");*/

        }

        private List<SubData> JsonParser(string json)
        {
            JArray array = JArray.Parse(json);
            datas.Clear();
            foreach (JObject item in array)
            {
                try { } catch (Exception) { }
#pragma warning disable CS8602 // null 가능 참조에 대한 역참조입니다.
                int id = int.Parse(item["id"].ToString());
                string title = item["title"].ToString();
                string description = item["description"].ToString();
                string img = item["img"].ToString();
                string imgurl = item["imgurl"].ToString();


                SubData subData;
                subData = new SubData(id,title,description,img,imgurl);
                datas.Add(subData);
            }
            return datas;
        }


    }
}
