using System;
using System.Net;
using KanjiNET.Enums;
using KanjiNET.Models;
using Newtonsoft.Json;

namespace KanjiNET
{
    // <summary>
    /// Kanji API Client used to retrieve definitions
    /// </summary>
    public class KanjiClient
    {
        private static Uri BaseUrl = new Uri("https://kanjiapi.dev/v1/");

        /// <summary>
        /// Retrieve a kanji's definition
        /// </summary>
        /// <param name="kanji">Kanji to look up</param>
        /// <returns><see cref="KanjiResult{KanjiDefinition}" /> definition of the kanji</returns>
        public KanjiResult<KanjiDefinition> GetKanjiDefinition(String kanji)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0");
                webClient.Headers.Add(HttpRequestHeader.AcceptCharset, "UTF-8");
                webClient.Encoding = System.Text.Encoding.UTF8;

                String jsonResponse = webClient.DownloadString(new Uri(BaseUrl + "kanji/" + kanji));
                KanjiResult<KanjiDefinition> result = new KanjiResult<KanjiDefinition>();
                result.Data = JsonConvert.DeserializeObject<KanjiDefinition>(jsonResponse);
                result.Success = true;
                return result;
            }
            catch (Exception e)
            {
                return new KanjiResult<KanjiDefinition>()
                {
                    Success = false,
                    Exception = e.ToString()
                };
            }
        }

        /// <summary>
        /// Retrieve all kanji by grade (1-8)
        /// </summary>
        /// <param name="grade">Grade</param>
        /// <returns><see cref="KanjiResult{String[]}" /> of all kanji in the given grade</returns>
        public KanjiResult<String[]> GetKanjiByGrade(Grade grade)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0");
                webClient.Headers.Add(HttpRequestHeader.AcceptCharset, "UTF-8");
                webClient.Encoding = System.Text.Encoding.UTF8;

                String jsonResponse = webClient.DownloadString(new Uri(BaseUrl + "kanji/grade-" + (Int32)grade));
                KanjiResult<String[]> result = new KanjiResult<String[]>();
                result.Data = JsonConvert.DeserializeObject<String[]>(jsonResponse);
                result.Success = true;
                return result;
            }
            catch (Exception e)
            {
                return new KanjiResult<String[]>()
                {
                    Success = false,
                    Exception = e.ToString()
                };
            }
        }

        /// <summary>
        /// Retrieve a list of kanji by reading
        /// </summary>
        /// <param name="reading">Reading or part of the reading of the kanji you want to look up (in kana)</param>
        /// <returns><see cref="KanjiResult{KanjiReading}" /> containing a list of matching kanji</returns>
        public KanjiResult<KanjiReading> GetKanjiByReading(String reading)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0");
                webClient.Headers.Add(HttpRequestHeader.AcceptCharset, "UTF-8");
                webClient.Encoding = System.Text.Encoding.UTF8;

                String jsonResponse = webClient.DownloadString(new Uri(BaseUrl + "reading/" + reading));
                KanjiResult<KanjiReading> result = new KanjiResult<KanjiReading>();
                result.Data = JsonConvert.DeserializeObject<KanjiReading>(jsonResponse);
                result.Success = true;
                return result;
            }
            catch (Exception e)
            {
                return new KanjiResult<KanjiReading>()
                {
                    Success = false,
                    Exception = e.ToString()
                };
            }
        }


        /// <summary>
        /// Retrieve a list of all words containing the given kanji
        /// </summary>
        /// <param name="kanji">Kanji to find words for</param>
        /// <returns><see cref="KanjiResult{KanjiWords[]}" /> </returns>
        public KanjiResult<KanjiWord[]> GetKanjiWords(String kanji)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0");
                webClient.Headers.Add(HttpRequestHeader.AcceptCharset, "UTF-8");
                webClient.Encoding = System.Text.Encoding.UTF8;

                String jsonResponse = webClient.DownloadString(new Uri(BaseUrl + "words/" + kanji));
                KanjiResult<KanjiWord[]> result = new KanjiResult<KanjiWord[]>();
                result.Data = JsonConvert.DeserializeObject<KanjiWord[]>(jsonResponse);
                result.Success = true;
                return result;
            }
            catch (Exception e)
            {
                return new KanjiResult<KanjiWord[]>()
                {
                    Success = false,
                    Exception = e.ToString()
                };
            }
        }
    }
}
