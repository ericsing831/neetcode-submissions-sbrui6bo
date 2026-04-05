public class TimeMap {

    private Dictionary<string, List<(string Emo, int TimeStamp)>> _map; 

    public TimeMap() {
        _map = new Dictionary<string, List<(string Emo, int TimeStamp)>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if (_map.TryGetValue(key, out var list)) {
            list.Add((value, timestamp));
        }
        else {
            _map[key] = new List<(string Emo, int TimeStamp)> {(value, timestamp)};
        }
    }
    
    public string Get(string key, int timestamp) {
        if (!_map.TryGetValue(key, out var list))
            return "";        

        var res = "";
        int l = 0, r = list.Count - 1;

        while (l <= r) {
            int m = (l + r) / 2;
            if (list[m].TimeStamp > timestamp) {
                r = m - 1;
            }
            else if (list[m].TimeStamp < timestamp) {
                res = list[m].Emo;
                l = m + 1;
            }
            else {
                res = list[m].Emo;
                return res;
            }
        }
        return res;
    }
}
