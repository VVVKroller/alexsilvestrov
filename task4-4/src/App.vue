<template> 
    <div id = "app">
      <HeaderNav />
      <main>
        <PostsLists />
        <NewsTab />  
      </main>
    </div>
</template>
  

<script>
import HeaderNav from './components/HeaderNav.vue';

import PostsLists from './components/PostsLists.vue';

import NewsTab from './components/NewsTab.vue';

export default {
  name: 'App',
  components: { 
    HeaderNav, 
    PostsLists,
    NewsTab
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}
main {
  display: flex;
  justify-content: space-between;
  align-items: center;
}
body {
  margin: 0;
}
</style>