<template>
  <header>
    <nav>
        <ul>
            <li>Home</li>
            <li>About</li>
            <li>Blog's Main Topic 1</li>
            <li>Blog's Main Topic 2</li>
            <li>Blog's Main Topic 3</li>
            <li>Associated blogs</li>
        </ul>

    </nav>
  </header>
</template>

<script>
export default {

}
</script>

<style scoped>

header {
    background-color: #2c3e50;
    color: white;
    display: flex;
    justify-content: center;
    align-items: center;
    height: 80px;
    width : 100%;
}
header > nav > ul {
    display: flex;
    justify-content: center;
    align-items: center;
    list-style: none;
}
header > nav > ul > li {
    margin: 0 20px;
}

</style>