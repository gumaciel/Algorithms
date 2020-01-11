#include <bits/stdc++.h>

using namespace std;

vector<string> split_string(string);


int index(int i) 
{ 
    return 1 + (i >> 31) - (-i >> 31); 
    // returns 0 if it is negative 
    // returns 1 if it is zero 
    // returns 2 if it is positive 
} 

void plusMinus(vector<int> arr) {
    int denominator = arr.size();
    vector<int> numbers {0, 0, 0}; /*   1st element[0] = negative, 2nd[1] = zero, 3rd[2] = positive */
    vector<int> order_printing {2, 0, 1};

    for (int i = 0; i < denominator; i++)
        numbers.at(index(arr.at(i)))++;
    
    for (unsigned int i = 0; i < order_printing.size(); i++)
        cout << float(numbers.at(order_printing.at(i)))/float(denominator) << endl;

}

int main()
{
    int n;
    cin >> n;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    string arr_temp_temp;
    getline(cin, arr_temp_temp);

    vector<string> arr_temp = split_string(arr_temp_temp);

    vector<int> arr(n);

    for (int i = 0; i < n; i++) {
        int arr_item = stoi(arr_temp[i]);

        arr[i] = arr_item;
    }

    plusMinus(arr);

    return 0;
}

vector<string> split_string(string input_string) {
    string::iterator new_end = unique(input_string.begin(), input_string.end(), [] (const char &x, const char &y) {
        return x == y and x == ' ';
    });

    input_string.erase(new_end, input_string.end());

    while (input_string[input_string.length() - 1] == ' ') {
        input_string.pop_back();
    }

    vector<string> splits;
    char delimiter = ' ';

    size_t i = 0;
    size_t pos = input_string.find(delimiter);

    while (pos != string::npos) {
        splits.push_back(input_string.substr(i, pos - i));

        i = pos + 1;
        pos = input_string.find(delimiter, i);
    }

    splits.push_back(input_string.substr(i, min(pos, input_string.length()) - i + 1));

    return splits;
}
