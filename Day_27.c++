

class TestDataEmptyArray
{
    public :
    static vector<int> get_array(){
        vector<int> a;
        return a;
    }
    
};
class TestDataUniqueValues{
    public: 
    static vector<int> get_array(){
        vector<int> a = {2,3,4,1,5,6,7};
        return a;
    };
    static int get_expected_result()
    {
    return 3;
    };
};
   
class TestDataExactlyTwoDifferentMinimums {
    public:
    static vector<int> get_array(){
        vector<int> a ={2,3,5,4,1,1};
        return a;
    };
     static int get_expected_result(){
         return 4;
     };
};

