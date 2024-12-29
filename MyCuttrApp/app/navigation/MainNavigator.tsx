import React from 'react';
import { createBottomTabNavigator } from '@react-navigation/bottom-tabs';
import MyProfileScreen from '../features/main/screens/MyProfileScreen';
import SettingsScreen from '../features/main/screens/SettingsScreen';
import SwipeScreen from '../features/main/screens/SwipeScreen';
import { Image, StyleSheet } from 'react-native';

const Tab = createBottomTabNavigator();

const icons: Record<string, number> = {
  Swipe: require('../../assets/images/swiping.png'),
  Profile: require('../../assets/images/profile.png'),
  Settings: require('../../assets/images/settings.png'),
};

const MainNavigator = () => {
  return (
    <Tab.Navigator
      screenOptions={({ route }) => ({
        headerShown: false,
        tabBarIcon: ({ focused, color, size }) => {
          const iconSource = icons[route.name];
          return (
            <Image
              source={iconSource}
              style={[
                styles.icon,
                { tintColor: focused ? '#673ab7' : '#222' },
                { width: size, height: size },
              ]}
            />
          );
        },
        tabBarActiveTintColor: '#673ab7',
        tabBarInactiveTintColor: 'gray',
      })}
    >
      <Tab.Screen name="Swipe" component={SwipeScreen}/>
      <Tab.Screen name="Profile" component={MyProfileScreen}/>
      <Tab.Screen name="Settings" component={SettingsScreen}/>
    </Tab.Navigator>
  );
};

export default MainNavigator;

const styles = StyleSheet.create({
  icon: {
    width: 24,
    height: 24,
  },
});