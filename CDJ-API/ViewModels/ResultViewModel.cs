namespace CDJ_API.ViewModels;
public class ResultViewModel<Type>{
    public Type? Data { get; set; }
    public List<string> Errors { get; set; } = new List<string>();
    public ResultViewModel(){}
    public ResultViewModel(Type data, string error){
        Data = data;
        Errors.Add(error);
    }
    public ResultViewModel(Type data){
        Data = data;
    }
        public ResultViewModel(string error){
        Errors.Add(error);
    }
}