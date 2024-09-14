using OpenAI.Chat;
using System.Text.Json;
namespace SimpleGPTCompletionApp
{
    public class GPTController
    {
        private string _apiKey;                                 // apiキー
        private ChatClient _chatClient;                         // gpt-4oとの通信を行うためのクライアント

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public GPTController () {
            _apiKey = GetAPIFromFile();
            _chatClient = new(model: "gpt-4o", _apiKey);
        }

        /// <summary>
        /// gpt-4oによるトーク生成
        /// </summary>
        /// <param name="inputBackground">事前情報</param>
        /// <param name="prevName">前に話した人の名前</param>
        /// <param name="prevTalk">前に話した内容(自分または他者が話した場合のどちらの場合もあり)</param>
        /// <param name="name">発話者名</param>
        /// <returns></returns>
        public string? GenerateTalk (string inputBackground, string restrict, string name) {

            string? prompt = GeneratePrompt(inputBackground, restrict, name);
            string? result = null;

            if (prompt == null) // プロンプト生成に失敗した場合
            {
                return null;
            }

            // トーク生成処理
            var completionResult = _chatClient.CompleteChat(prompt);
            if (completionResult != null)
            {
                var binaryResult = completionResult.GetRawResponse().Content;
                using JsonDocument jsonResult = JsonDocument.Parse(binaryResult);
                result = GetJsonFromResult(jsonResult);
            }

            return result;
        }

        /// <summary>
        /// gptに渡すプロンプト(文字列)を生成
        /// </summary>
        /// <param name="baseData">前提知識(会話背景)</param>
        /// <param name="talkHistory">過去の会話履歴の入ったリスト</param>
        /// <returns>生成したプロンプトの文字列</returns>
        public string? GeneratePrompt (string baseData,string restrict, string name) {

            // プロンプトの生成
            string prompt = $@"
                自分の名前は{name}です
                背景知識として「{baseData}」があります。
                これらの会話履歴を用いて、以下の制約を守りながら、自身の次の発話内容をJson形式で生成してください。
                内容に対する制約：「{restrict}」
                生成フォーマット：「発話者: {name}, 発話内容: ここに発話内容を記入」
                ";


            return prompt;
        }

        /// <summary>
        /// APIキーの保存されているファイルからAPIキーを取得する
        /// </summary>
        /// <returns>APIキー(文字列)</returns>
        public string GetAPIFromFile () {
            string content = "";

            MessageBox.Show("APIキーの保存されているファイルを選択してください。");

            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "APIキーの保存されているファイルを開く";
                dialog.Filter = "テキストファイル(*.txt)|*.txt|すべてのファイル(*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    content = File.ReadAllText(dialog.FileName);
                }
            }

            return content;
        }

        public string? GetJsonFromResult (JsonDocument jsonTalkData) {
            var generateTalk = jsonTalkData.RootElement // トーク生成結果の取得
                .GetProperty("choices"u8)[0]
                .GetProperty("message"u8)
                .GetProperty("content"u8)
                .GetString();

            if (generateTalk == null)
            {
                return null;
            }

            generateTalk = generateTalk.Replace("\n", "");
            generateTalk = generateTalk.Replace($@"`", "");
            generateTalk = generateTalk.Replace("json", "");

            JsonElement root;
            try
            {
                var jsonDocument = JsonDocument.Parse(generateTalk);                             // 生成されたトークのJson形式の解析
                root = jsonDocument.RootElement;                                     // 生成されたトークのJson形式のルート要素の取得
            }
            catch (JsonException)
            {
                return null;
            }


            string? speaker = root.GetProperty("発話者").GetString();                         // 発話者の取得
            string? content = root.GetProperty("発話内容").GetString();                       // 発話内容の取得

            return $"{speaker} : 「{content}」";
        }
    }
}
