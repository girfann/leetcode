use std::collections::HashMap;

pub struct Solution;

impl Solution {
    pub fn two_sum(nums: Vec<i32>, target: i32) -> Vec<i32> {
        let mut value_to_index = HashMap::with_capacity(nums.len());

        for (index, &value) in nums.iter().enumerate() {
            let required_value = target - value;

            if let Some(&previous_index) = value_to_index.get(&required_value) {
                return vec![previous_index as i32, index as i32];
            }

            value_to_index.entry(value).or_insert(index);
        }

        Vec::new()
    }
}

#[cfg(test)]
mod tests {
    use super::Solution;
    use rstest::rstest;

    #[rstest]
    #[case(vec![2,7,11,15], 9, vec![0,1])]
    #[case(vec![3,2,4],     6, vec![1,2])]
    #[case(vec![3,3],       6, vec![0,1])]
    fn two_sum_ok(#[case] nums: Vec<i32>, #[case] target: i32, #[case] want: Vec<i32>) {
        assert_eq!(Solution::two_sum(nums, target), want);
    }
}
