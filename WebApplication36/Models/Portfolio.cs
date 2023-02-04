using System.Text.Json;
using System.Text.Json.Serialization;

namespace WebApplication36.Models
{
    public class Portfolio
    {

        //모델클래스 
        public int Id { get; set; } //prop tab tab으로 poroperty 생성 -> Id로 필드명 변경
        public string Title { get; set; }
        public string Description { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }

        public override string ToString() //overide Tostring Tab 누르면 자동 완성
        {
            return JsonSerializer.Serialize<Portfolio>(this); //포트폴리오의 나 자신을 요청하면  위 객체들을 json 변환
        }

    }
}
