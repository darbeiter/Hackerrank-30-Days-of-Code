#include <iostream>
#include <vector>
#include <stdexcept>
#include <cassert> // Include this for using assert
#include <set>
#include <algorithm> // Include this for using sort

using namespace std;

class TestDataEmptyArray {
public:
    static vector<int> get_array() {
        return {}; // Return an empty array
    }
};

class TestDataUniqueValues {
public:
    static vector<int> get_array() {
        // Return an array of size at least 2 with all unique elements
        return {1, 2};
    }

    static int get_expected_result() {
        // Return the expected minimum value index for this array (minimum is at index 0)
        return 0;
    }
};

class TestDataExactlyTwoDifferentMinimums {
public:
    static vector<int> get_array() {
        // Return an array where the minimum value occurs at exactly 2 indices
        return {1, 2, 1};
    }

    static int get_expected_result() {
        // Return the expected index (minimum is at index 0)
        return 0;
    }
};

int minimum_index(vector<int> seq) {
    if (seq.empty()) {
        throw invalid_argument("Cannot get the minimum value index from an empty sequence");
    }
    int min_idx = 0;
    for (int i = 1; i < seq.size(); ++i) {
        if (seq[i] < seq[min_idx]) {
            min_idx = i;
        }
    }
    return min_idx;
}

void TestWithEmptyArray() {
    try {
        auto seq = TestDataEmptyArray::get_array();
        auto result = minimum_index(seq);
    } catch (invalid_argument& e) {
        return;
    }
    assert(false);
}

void TestWithUniqueValues() {
    auto seq = TestDataUniqueValues::get_array();
    assert(seq.size() >= 2);

    assert(set<int>(seq.begin(), seq.end()).size() == seq.size());

    auto expected_result = TestDataUniqueValues::get_expected_result();
    auto result = minimum_index(seq);
    assert(result == expected_result);
}

void TestWithExactlyTwoDifferentMinimums() {
    auto seq = TestDataExactlyTwoDifferentMinimums::get_array();
    assert(seq.size() >= 2);

    auto tmp = seq;
    sort(tmp.begin(), tmp.end());
    assert(tmp[0] == tmp[1] and (tmp.size() == 2 or tmp[1] < tmp[2]));

    auto expected_result = TestDataExactlyTwoDifferentMinimums::get_expected_result();
    auto result = minimum_index(seq);
    assert(result == expected_result);
}

int main() {
    TestWithEmptyArray();
    TestWithUniqueValues();
    TestWithExactlyTwoDifferentMinimums();
    cout << "OK" << endl;
    return 0;
}
