import instaloader
L = instaloader.Instaloader()
username = "username"
password = "password"
L.login(username, password)
profile = instaloader.Profile.from_username(L.context, username)
followers_list = []
count_followers = 0
for followee in profile.get_followers():
    followers_list.append(followee.username)
    count_followers = count_followers + 1
following_list = []
count_following = 0
for followee in profile.get_followees():
    following_list.append(followee.username)
    count_following = count_following + 1
bad_people = set(following_list) - set(followers_list)
print(bad_people)
