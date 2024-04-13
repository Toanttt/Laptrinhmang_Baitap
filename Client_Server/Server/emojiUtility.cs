using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class emojiUtility
    {
        string s = "\u1F54";
        // Tạo danh sách các Unicode tương ứng với các emoji
        private Dictionary<string, string> emojis = new Dictionary<string, string>()
            {
                { "🙂", "1F642" },
                { "😀", "1F600" },
                { "😂", "1F602" },
                { "😃", "1F603" },
                { "😄", "1F604" },
                { "😅", "1F605" },
                { "😆", "1F606" },
                { "😉", "1F609" },
                { "😊", "1F60A" },
                { "😋", "1F60B" },
                { "😎", "1F60E" },
                { "😍", "1F60D" },
                { "😘", "1F618" },
                { "😗", "1F617" },
                { "😙", "1F619" },
                { "😇", "1F607" }
                // Thêm các emoji khác vào đây
            };
        // Phương thức getter công khai
        public Dictionary<string, string> GetEmojis()
        {
            return emojis;
        }

        public static string ConvertUnicodeToEmoji(string message)
        {
            // Kiểm tra xem tin nhắn có bắt đầu bằng "\U" không
            if (message.StartsWith("\\U"))
            {
                // Loại bỏ "\U" từ tin nhắn
                string unicode = message.Substring(2);

                // Chuyển đổi mã Unicode thành emoji
                try
                {
                    int unicodeInt = int.Parse(unicode, System.Globalization.NumberStyles.HexNumber);
                    return char.ConvertFromUtf32(unicodeInt);
                }
                catch (FormatException)
                {
                    // Nếu không thể chuyển đổi, trả về tin nhắn gốc
                    return message;
                }
            }
            else
            {
                // Nếu tin nhắn không bắt đầu bằng "\U", trả về tin nhắn gốc
                return message;
            }
        }
    }
}
